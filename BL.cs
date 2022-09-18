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
        
        public void initDB()
        {
            if (sql)
            {
                DataAccess.CreateDatabase();
                DataAccess.createTables();
                DataAccess.createIngred();
                DataAccess.fillIngred();
            }
            else
            {
                mongoDB.connectNoSql();
                mongoDB.createIngreadientsTable();
            }
        }
        public void change_to_noSQL()
        {
            if (sql)
            {
                this.sql = false;
            }
            else
            {
                this.sql = false;
            }
        }
        public Order newOrder()
        {
            Order order = new Order();
            return order;
        }
        public void insertOrder(Order order)
        {
            if (sql)
            {
                DataAccess.insertToDB(order);
            }
            else
            {
                mongoDB.createDishes_SalesTables(order);
            }
            }
        
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


        public string showBestFlavor()
        {
            if (sql)
            {
                return DataAccess.best_falvor();
            }
            else
            {
                return (mongoDB.mongo_best_falvor());
            }
        }

        public string showBestTopping()
        {
            if(sql)
            {
                return DataAccess.best_topping();
            }
            else
            {
                return mongoDB.mongo_best_Topping();
            }
        }
    }
}


        