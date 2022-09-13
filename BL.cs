using DataAccessLayer;
using IcecreamMenu;

namespace BusinessLogic
{
    public class BLAccess
    {

        SqlAccess DataAccess = new SqlAccess();
        
      //*****need to add the functions*****//
        
        public void initDB()
        {
            DataAccess.CreateDatabase();
            DataAccess.createTables();
            DataAccess.createIngred();
            DataAccess.fillIngred();
            //return true;
        }

        public Order newOrder()
        {
            Order order = new Order();
            return order;
        }
        public void insertOrder(Order order)
        {
            DataAccess.insertToDB(order);
        }
        
        public string show_report(string date)
        {
            string ans =DataAccess.SalesSum(date);
            return ans;
        }
        
        public string showUnfinished_Sales()
        {
            return DataAccess.UnfinishedSale();
        }


        public string showBestFlavor()
        {
            return DataAccess.best_falvor();
        }
    }
}


        