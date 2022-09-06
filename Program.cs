using System;
//using System.Data;
//using DataAccessLayer;
//using BusinessLogic;
//using IcecreamMenu;
//using System.Drawing;
//using System.Windows.Forms;
using IceCreamShop1;
 
//namespace winFormsapp { 

//public partial class PL : Form
//{
//   public  Form1()
//        {
//            In
//        }
//        BLAccess BL = new BLAccess();
//        void calculateOrder()
//    {
//        Form form = new Form();
//        Button button1;
//        button1 = new Button();
//        button1.Size = new Size(40, 40);
//        button1.Location = new Point(30, 30);
//        button1.Text = "Click me";
//        Order order = BL.newOrder();
//    }



        
//        int userInput = 0;
//        do
//        {
//            Console.WriteLine("_____________________");
//            Console.WriteLine("Please chose a task:");
//            Console.WriteLine("1 - create empty tables");
//            Console.WriteLine("2 - Add Order items");
//            Console.WriteLine("");
//            Console.WriteLine("(-1) - for exit");
//            BLAccess BL = new BLAccess();

//            userInput = Int32.Parse(Console.ReadLine());
//            switch (userInput)
//            {
//                case 1:
//                    BL.initDB();
//                    break;
//                case 2:
//                    order.addFlavor(Flavor.Vanilla);
//                    order.addFlavor(Flavor.Banana);
//                    order.addTop(Toppings.HotChocolate);
//                    BL.insertOrder(order);
//                    break;
//                default: break;
//            }

//        } while (userInput != -1);

//        Console.WriteLine("Thank you for your time");
//    }
//}