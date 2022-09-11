
using BusinessLogic;
using System.Collections;
using IcecreamMenu;
using System.Data.SqlClient;
using System;


namespace DataAccessLayer
{
    class SqlAccess
    {

        public SqlConnection connectSql()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.ConnectionString = @"Server=DESKTOP-F06T9D8\SQLEXPRESS;Database=OurIceCream;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(builder.ConnectionString);
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            throw new ArgumentException("Couldn't  connect to SQL server");
        }

        public Boolean CreateDatabase()
        {
            try
            {
                SqlConnection conn = connectSql();
                conn.Open();
                string sql = "CREATE DATABASE OurIceCream;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return true;
        }
        public Boolean createTables()
        {

            SqlConnection connection = connectSql();
            connection.Open();
            SqlCommand cmd;
            string sql;
            try
            {
                sql =
                    "DROP TABLE IF EXISTS Dishes;"+
                    "CREATE TABLE Dishes (" +
                    "Did INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                    "ingredID VARCHAR(45) NULL," +
                    "salesID VARCHAR(45) NULL," +
                    "amount INT NOT NULL);";

                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                sql =
                    "DROP TABLE IF EXISTS Sales;"+
                    "CREATE TABLE Sales (" +
                    "Sid INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                    "date VARCHAR(45) NOT NULL," +
                    "price INT NOT NULL);";

                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return true;
        }

        public Boolean createIngred()
        {
            SqlConnection connection = connectSql();
            connection.Open();
            SqlCommand cmd;
            string sql;
            sql = "DROP TABLE IF EXISTS Ingredients;" +
                        "CREATE TABLE Ingredients ( " +
                        "Sid INT NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                        "name VARCHAR(20) NULL);";
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            return true;
        }

        public Boolean fillIngred()
        {
            SqlConnection connection = connectSql();
            connection.Open();
            SqlCommand cmd;
            string sql;
            string[] vars;
            vars = Enum.GetNames(typeof(Toppings));
            foreach (string topping in vars)
            {
                sql = $"INSERT INTO Ingredients(name) VALUES('{topping}');";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

            }
            vars = Enum.GetNames(typeof(Flavor));
            foreach (string enumValue in vars)
            {
                sql = $"INSERT INTO Ingredients(name) VALUES('{enumValue}');";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            vars = Enum.GetNames(typeof(Cups));
            foreach (string enumValue in vars)
            {
                sql = $"INSERT INTO Ingredients(name) VALUES('{enumValue}');";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            return true;
        }


        public void insertToDB(Order order)
        {
            SqlConnection connection = connectSql();
            connection.Open();
            SqlCommand cmd;
            string sql;
            //foreach (Flavor fl in order.BallFlavors)
            sql = $"INSERT INTO Sales VALUES('{order.date}','{order.price}');";
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            int[] ingredients_list = new int[13];
            foreach(var flavor in order.BallFlavors)
            {
                ingredients_list[(int)flavor]++;
            }
            foreach (var topping in order.Topp)
            {
                ingredients_list[(int)topping]++; 
            }
            for (int i = 0; i < ingredients_list.Length; i++) {
                if (ingredients_list[i] > 0)
                {
                    sql = $"INSERT INTO Dishes VALUES('{i}','{order.order_id}','{ingredients_list[i]}');";
                    cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}