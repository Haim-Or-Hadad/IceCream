using DataAccessLayer;
using IcecreamMenu;
using MongoDB.Driver;
using System;

namespace BusinessLogic
{
    public class BLAccess
    {

        SqlAccess DataAccess = new SqlAccess();
        mongoDB_DAL mongoDB = new mongoDB_DAL();
        Boolean sql = true;
        //*****need to add the functions*****//

        /// <summary>
        /// Init the Database.
        /// fill the tables delete previous data
        /// </summary>
        public void initDB()
        {
            if (sql)
            {
                DataAccess.CreateDatabase();
                DataAccess.createTables();
                DataAccess.fillIngred();
            }
            else
            {
                mongoDB.connectNoSql();
                mongoDB.createIngreadientsTable();
            }
        }

        /// <summary>
        ///     sql - use the SQL database
        ///     else - use the MongoDB database
        /// </summary>
        public void change_to_noSQL()
        {
            if (sql)
            {
                this.sql = false;
            }
            else
            {
                this.sql = true;
            }
        }

        /// <summary>
        /// Create a new order.
        /// </summary>
        /// <returns>new order created</returns>
        public Order newOrder()
        {
            Order order = new Order();
            return order;
        }

        /// <summary>
        /// Insert the order the customer made.
        /// according to the db selected
        /// </summary>
        /// <param name="order">The order</param>
        public void insertOrder(Order order)
        {
            if (sql)
            {
                DataAccess.insertToDB(order);
            }
            else
            {
                mongoDB.MongoInsertToDB(order);
            }
            }
        
        /// <summary>
        /// Show the daily report of the givin date.
        /// </summary>
        public string show_report(string date)
        {
            if (sql)
            {
                return (DataAccess.SalesSum(date));
            }
            else
            {
                return( mongoDB.SaleSum_Mongo(date));
            }
        }

        /// <summary>
        /// Show the unfinished sales according to the db selected
        /// </summary>
        public string showUnfinished_Sales()
        {
           if (sql)
            {
                return DataAccess.UnfinishedSale();
            }
            else
            {
                return mongoDB.mongo_UnfinishedSale();
            }
            }

        /// <summary>
        /// Return the best seller according to the db selected.
        /// and the selector picked.
        /// </summary>
        /// <param name="selector"></param>
        public string showBestSeller(int selector)
        {
            if (sql)
            {
                return DataAccess.BestSellers(selector);
            }
            else
            {
                return mongoDB.mongoBestSellers(selector);
            }
        }
    }
}


        