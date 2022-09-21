using BusinessLogic;
using System.Collections;
using IcecreamMenu;
using System.Data.SqlClient;
using System;


namespace DataAccessLayer
{
    class SqlAccess
    {
        /// <summary>
        /// Create a connection to the sql server
        /// </summary>
        /// <returns>connection to the server</returns>
        public SqlConnection connectSql()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=OurIceCream;Trusted_Connection=True;";

                //builder.ConnectionString = @"Server=DESKTOP-F06T9D8\SQLEXPRESS;Database=OurIceCream;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(builder.ConnectionString);
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            throw new ArgumentException("Couldn't  connect to SQL server");
        }

        /// <summary>
        /// Crate the icecream shop db
        /// </summary>
        public void CreateDatabase()
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
        }

        /// <summary>
        /// Create the Ingredients, Dishes and Sales tables
        /// </summary>
        public void createTables()
        {

            SqlConnection connection = connectSql();
            connection.Open();
            SqlCommand cmd;
            string sql;
            try
            {
                sql =
                    "DROP TABLE IF EXISTS Dishes;" +
                    "CREATE TABLE Dishes " +
                    "(Did INT NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                    "ingredID VARCHAR(45) NULL," +
                    "salesID VARCHAR(45) NULL," +
                    "amount INT NOT NULL);";

                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                sql =
                    "DROP TABLE IF EXISTS Sales;" +
                    "CREATE TABLE Sales (" +
                    "Sid INT NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                    "date VARCHAR(45) NOT NULL," +
                    "price INT NOT NULL);";

                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                sql = "IF OBJECT_ID('Ingredients') IS NOT NULL DROP TABLE Ingredients;" +
                       "CREATE TABLE Ingredients ( " +
                       "ingredID INT NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                       "name VARCHAR(20) NULL);";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// fill the ingredients table
        /// </summary>
        public void fillIngred()
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
        }

        /// <summary>
        /// Insert the order given by the user to the data base.
        /// iterating over the order and add each element by the id givin to him in the enum class.
        /// </summary>
        /// <param name="order">the current order</param>
        /// <exception cref="Exception"></exception>
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
            int[] ingredients_list = new int[16];
            if(order.BallFlavors.Count < 2 && order.Topp.Count >=1 && order.cupType==Cups.Reagular)
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
                    
                    sql = $"INSERT INTO Dishes VALUES('{i}','{order.order_id}','{ingredients_list[i]}');";
                    cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// return sale summary of the given date.
        /// include avarage sale price, total money earend and total sales made.
        /// </summary>
        /// <param name="date">date</param>
        /// <returns>Sale summary of the given date</returns>
        public string SalesSum(string date)
        {
            int avag = 0;
            int count = 0;
            int sum = 0;
            SqlConnection connection = connectSql();
            connection.Open();
            string dailySales = "";
            string sql = $"SELECT SUM(price) FROM Sales WHERE date LIKE '{date}%';";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader Sqlreader = cmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                sum = Sqlreader.GetInt32(0);
            }
            Sqlreader.Close();
            sql = $"SELECT COUNT(price) FROM Sales WHERE date LIKE '{date}%';";
            cmd = new SqlCommand(sql, connection);
            Sqlreader = cmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                count = Sqlreader.GetInt32(0);
            }
            Sqlreader.Close();
            avag = (count == 0) ? 0 : (sum / count);


            dailySales = date + " Sales summary: \n Sales:" + count + " \n Income: " + sum + "\n Average Daily Sales: " + avag;

            return dailySales;
        }

        /// <summary>
        /// return all the unfinished sales.
        /// unfinished sales are sales there price is saved with -1 when the rest button is pressed.
        /// </summary>
        /// <returns>all the unfinished sales</returns>
        public string UnfinishedSale()
        {

            SqlConnection connection = connectSql();
            connection.Open();
            string unfinishedData = "The uncompleted orders are: \n";
            string sql = $"SELECT SID,date FROM Sales WHERE price=-1;";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader Sqlreader = cmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                unfinishedData += "SID: "+Sqlreader["SID"].ToString() + " Date: " + Sqlreader["date"].ToString() + "\n";
            }
            Sqlreader.Close();
            return unfinishedData;
        }

        /// <summary>
        /// Return the name id and amount of the best selling item according to the selector.
        /// </summary>
        /// <param name="selector">
        /// 0-best flavor
        /// 1-best topping
        /// 2-overall
        /// </param>
        /// <returns>Best seller according to the category</returns>
        public string BestSellers(int selector)
        {
            SqlConnection connection = connectSql();
            connection.Open();
            string popularSelection = "";
            string sql = "";
            if (selector == 0)
            {
                popularSelection = "The the most popular flavor is: \n";
                sql = $"SELECT TOP(1) *" +
                             "FROM Ingredients " +
                             "INNER JOIN" +
                             "(SELECT SUM(amount) as total , " +
                             "ingredID " +
                             "FROM Dishes " +
                             "WHERE ingredID >= 4 AND ingredID <=13 " +
                             "GROUP BY ingredID) as table1 " +
                             "ON table1.ingredID = Ingredients.ingredID " +
                             "ORDER BY table1.total DESC;";
            }
            else if (selector == 1)
            {
                popularSelection = "The the most popular topping is: \n";
                 sql = $"SELECT TOP(1) *" +
                             "FROM Ingredients " +
                             "INNER JOIN" +
                             "(SELECT SUM(amount) as total , " +
                             "ingredID " +
                             "FROM Dishes " +
                             "WHERE ingredID >= 1 AND ingredID <=3 " +
                             "GROUP BY ingredID) as table1 " +
                             "ON table1.ingredID = Ingredients.ingredID " +
                             "ORDER BY table1.total DESC;";
            }
            else
            {
                popularSelection = "The the most popular item is: \n";
                sql = $"SELECT TOP(1) *" +
                            "FROM Ingredients " +
                            "INNER JOIN" +
                            "(SELECT SUM(amount) as total , " +
                            "ingredID " +
                            "FROM Dishes " +
                            "GROUP BY ingredID) as table1 " +
                            "ON table1.ingredID = Ingredients.ingredID " +
                            "ORDER BY table1.total DESC;";
            }

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader Sqlreader = cmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                popularSelection +=  "ID: " + Sqlreader["ingredID"].ToString() + " Name: " + Sqlreader["name"].ToString() + " Total bought: " + Sqlreader["total"].ToString();
            }
            Sqlreader.Close();

            return popularSelection;
        }


    }

}