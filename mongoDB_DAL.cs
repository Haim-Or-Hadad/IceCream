using IcecreamMenu;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DataAccessLayer
{
    class mongoDB_DAL
    {
        public IMongoDatabase connectNoSql()
        {
            try
            {
                MongoClient mongoClient = new MongoClient("mongodb+srv://IceCream:ice123456@icecreamcluster.eauxj7x.mongodb.net/test\r\n");
                IMongoDatabase iceCreamDB = mongoClient.GetDatabase("OurIceCream");
                return iceCreamDB;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            throw new ArgumentException("Couldn't connect to MongoDB server");
        }


        public void createIngreadientsTable()
        {
            IMongoDatabase db = connectNoSql();
            db.DropCollection("Ingreidients");
            db.DropCollection("Dishes");
            db.DropCollection("Sales");
            var ingredients_coll = db.GetCollection<BsonDocument>("Ingreidients");
            int id_counter = 1;
            var topping_values = Enum.GetValues(typeof(Toppings));
            for (int i = 0; i < topping_values.Length; i++)
            {
                string json = "{ 'Name': '" + topping_values.GetValue(i) + "', 'ingredID': " + id_counter++ + "}";
                ingredients_coll.InsertOne(BsonDocument.Parse(json));

            }
            var flavor_values = Enum.GetValues(typeof(Flavor));
            for (int i = 0; i < flavor_values.Length; i++)
            {
                string json = "{ 'Name': '" + flavor_values.GetValue(i) + "', 'ingredID': " + id_counter++ + "}";
                ingredients_coll.InsertOne(BsonDocument.Parse(json));
            }
            var Cups_values = Enum.GetValues(typeof(Cups));
            for (int i = 0; i < Cups_values.Length; i++)
            {
                string json = "{ 'Name': '" + Cups_values.GetValue(i) + "', 'ingredID': " + id_counter++ + "}";
                ingredients_coll.InsertOne(BsonDocument.Parse(json));
            }
        }

        public void MongoInsertToDB(Order order) {

            IMongoDatabase db = connectNoSql();
            var dishesTable = db.GetCollection<BsonDocument>("Dishes");
            //count the number of diffrent dishes so far.
            var Did = dishesTable.Distinct<string>("salesID", "{}").ToList().Count +1;
            ////////////////////////////////
            int[] ingredients_list = new int[16];
            if (order.BallFlavors.Count < 2 && order.Topp.Count >= 1 && order.cupType == Cups.Reagular)
            {
                throw new Exception("You need 2 ice cream balls to add toppings in a reagular cup");
            }
            ingredients_list[(int)order.cupType]++;
            foreach (var flavor in order.BallFlavors)
            {
                ingredients_list[(int)flavor]++;

            }
            foreach (var topping in order.Topp)
            {
                ingredients_list[(int)topping]++;
            }
            

            for (int i = 0; i < ingredients_list.Length; i++)
            {

                if (ingredients_list[i] > 0)
                {
                    string json1 = "{ 'Did': '" + Did + "', 'ingredID': '" + i + "', 'salesID': '" + Did + "', 'amount': '" + ingredients_list[i] + "'}";
                    dishesTable.InsertOne(BsonDocument.Parse(json1));
                }

            }
            var salesTable = db.GetCollection<BsonDocument>("Sales");
            string json2 = "{ 'Sid': '" + Did + "', 'Date': '" + order.date + "', 'Price': '" + order.price + "'}";
            salesTable.InsertOne(BsonDocument.Parse(json2));

        }
        /// <summary>
        /// Reuturn all the sales made at the given date.
        /// </summary>
        /// <param name="orderDate">The Date that the user want the sales from </param>
        /// <returns></returns>
        public string SaleSum_Mongo(string orderDate)
        {
            IMongoDatabase db = connectNoSql();
            var salesTable = db.GetCollection<BsonDocument>("Sales");
            var filter = Builders<BsonDocument>.Filter.Regex("Date", new BsonRegularExpression(orderDate));
            var result = salesTable.Find(filter).ToList();
            int count = result.Count;
            int sum = 0;
            foreach (var item in result)
            {
                sum += item.GetValue("Price").ToInt32();
            }
            int avag = (count == 0) ? 0 : (sum / count);
            string dailySales = orderDate + " Sales summary: \n Sales:" + count + " \n Income: " + sum + "\n Average Daily Sales: " + avag;


            return dailySales;
        }

        /// <summary>
        /// return all the unfinished sales.
        /// </summary>
        /// <returns></returns>
        public string mongo_UnfinishedSale()
        {
            IMongoDatabase db = connectNoSql();
            var salesTable = db.GetCollection<BsonDocument>("Sales");
            var filter = Builders<BsonDocument>.Filter.Regex("Price", new BsonRegularExpression("-1"));
            var result = salesTable.Find(filter).ToList();
            var count = result.Count;
            return "There are " + count + " uncompleted orders.";
        }

        /// <summary>
        /// Return the name id and amount of the best selling item according to the selector.
        /// </summary>
        /// <param name="selector">
        /// 0-best flavor
        /// 1-best topping
        /// 2-overall
        /// </param>
        /// <returns></returns>
        public string mongoBestSellers(int selector)
        {
            IMongoDatabase db = connectNoSql();
            var dishesTable = db.GetCollection<BsonDocument>("Dishes");
            var filter = Builders<BsonDocument>.Filter.Empty;
            IDictionary<int, int> Selling_list = new Dictionary<int, int>();
            string popularSelection = "";
            foreach (var item in dishesTable.Find(filter).ToListAsync().Result)
            {
                int ingredID = item.GetValue("ingredID").ToInt32();
                if (selector == 0)
                {
                    if (ingredID >= 4 && ingredID <= 13)
                    {
                        int amount = item.GetValue("amount").ToInt32();
                        if (Selling_list.ContainsKey(ingredID))
                        {
                            Selling_list[ingredID] += amount;
                        }
                        else
                        {
                            Selling_list.Add(ingredID, amount);
                        }
                    }
                     popularSelection = "The the most popular flavor is: \n";


                }
                else if(selector == 1)
                {
                    if (ingredID <= 3)
                    {
                        int amount = item.GetValue("amount").ToInt32();
                        if (Selling_list.ContainsKey(ingredID))
                        {
                            Selling_list[ingredID] += amount;
                        }
                        else
                        {
                            Selling_list.Add(ingredID, amount);
                        }
                    }
                    popularSelection = "The the most popular Topping is: \n";

                }
                else
                {
                    int amount = item.GetValue("amount").ToInt32();
                    if (Selling_list.ContainsKey(ingredID))
                    {
                        Selling_list[ingredID] += amount;
                    }
                    else
                    {
                        Selling_list.Add(ingredID, amount);
                    }
                    popularSelection = "The the most popular Item is: \n";

                }

            }
            var popularSelectionAmount = Selling_list.Values.Max();
            var popularSelectionId = Selling_list.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            string popularSelectionName;
            if (popularSelectionId <= 3)
            {
                popularSelectionName = Enum.GetName(typeof(Flavor), popularSelectionId);

            }
            else if (popularSelectionId>=4 && popularSelectionId<=13)
            {
                popularSelectionName = Enum.GetName(typeof(Toppings), popularSelectionId);

            }
            else
            {
                popularSelectionName = Enum.GetName(typeof(Cups), popularSelectionId);
            }
            var bestFlavorName = Enum.GetName(typeof(Flavor), popularSelectionId);
            popularSelection += "ID: " + popularSelectionId + "\n Name: " + bestFlavorName + "\n Total bought: " + popularSelectionAmount;
            return popularSelection;
        }



    }


 }
    

