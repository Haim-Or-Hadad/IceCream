using DataAccessLayer;
using IcecreamMenu;

namespace BusinessLogic
{
    public class BLAccess
    {

        SqlAccess DataAccess = new SqlAccess();
      //*****need to add the functions*****//
        
        public Boolean initDB()
        {
            DataAccess.CreateDatabase();
            DataAccess.createTables();
            DataAccess.createIngred();
            DataAccess.fillIngred();
            return true;
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


    }
}


        