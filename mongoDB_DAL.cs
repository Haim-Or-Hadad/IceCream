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

        public void createDishes_SalesTables(Order order) {

            IMongoDatabase db = connectNoSql();
            var dishesTable = db.GetCollection<BsonDocument>("Dishes");
            //count the number of diffrent dishes so far.
            var Did = dishesTable.Distinct<string>("salesID", "{}").ToList().Count +1;
            ////////////////////////////////
            int[] ingredients_list = new int[14];
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

        public string mongo_UnfinishedSale()
        {
            IMongoDatabase db = connectNoSql();
            var salesTable = db.GetCollection<BsonDocument>("Sales");
            var filter = Builders<BsonDocument>.Filter.Regex("Price", new BsonRegularExpression("-1"));
            var result = salesTable.Find(filter).ToList();
            var count = result.Count;
            return "There are " + count + " uncompleted orders.";
        }

        public string mongo_best_falvor()
        {
            IMongoDatabase db = connectNoSql();
            var dishesTable = db.GetCollection<BsonDocument>("Dishes");
            var filter = Builders<BsonDocument>.Filter.Empty;
            IDictionary<int, int> Selling_list = new Dictionary<int, int>();
            foreach (var item in dishesTable.Find(filter).ToListAsync().Result)
            {
                int ingredID = item.GetValue("ingredID").ToInt32();
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
            }
            var bestFlavorAmount = Selling_list.Values.Max();
            var bestFlavorId = Selling_list.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var bestFlavorName = Enum.GetName(typeof(Flavor), bestFlavorId);
            string popularFlavor = "The the most popular flavor is: \n";
            popularFlavor += "ID: " + bestFlavorId + " Name: " + bestFlavorName + " Total bought: " + bestFlavorAmount;
            return popularFlavor;
        }

        public string mongo_best_Topping()
        {
            IMongoDatabase db = connectNoSql();
            var dishesTable = db.GetCollection<BsonDocument>("Dishes");
            var filter = Builders<BsonDocument>.Filter.Empty;
            IDictionary<int, int> Selling_list = new Dictionary<int, int>();
            foreach (var item in dishesTable.Find(filter).ToListAsync().Result)
            {
                int ingredID = item.GetValue("ingredID").ToInt32();
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
            }
            var bestToppingAmount = Selling_list.Values.Max();
            var bestToppingId = Selling_list.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var bestToppingName = Enum.GetName(typeof(Toppings), bestToppingId);
            string popularTopping = "The the most popular Topping is: \n";
            popularTopping += "ID: " + bestToppingId + " Name: " + bestToppingName + " Total bought: " + bestToppingAmount;
            return popularTopping;
        }



    }


 }
    

