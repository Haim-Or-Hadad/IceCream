using IcecreamMenu;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DataAccessLayer
{
    class mongoDB_DAL
    {
        public IMongoDatabase connectNoSql()
        {
            try
            {
                MongoClient mongoClient = new MongoClient("mongodb+srv://IceCream:ice123456@icecreamcluster.eauxj7x.mongodb.net/test");
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
            var Sales_coll = db.GetCollection<BsonDocument>("Sales");
            string json = "{ 'Sid': '" + order.order_id + "', 'date': '" + order.date + "', 'price': '" + order.price + "'}";
            Sales_coll.InsertOne(BsonDocument.Parse(json));

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
            var Dishes_coll = db.GetCollection<BsonDocument>("Dishes");

            for (int i = 0; i < ingredients_list.Length; i++)
            {

                if (ingredients_list[i] > 0)
                {
                    var filter = Builders<Order>.Filter.Gt("salesID", 0);
                    int test = ((int)Dishes_coll.Count(filter)) + 1;
                    json = "{ 'Did': '" + test + "', 'ingredID': '" + i + "', 'salesID': '" + order.order_id + "', 'amount': '" + ingredients_list[i] + "'}";
                    Dishes_coll.InsertOne(BsonDocument.Parse(json));
                }

            }
        }
  
    
    }


 }
    

