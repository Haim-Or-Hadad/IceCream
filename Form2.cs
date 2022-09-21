using System;
using System.Windows.Forms;
using BusinessLogic;
using IcecreamMenu;


namespace IceCreamShop1
{
    public partial class Form2 : Form
    {
        BLAccess form2_bl;
        Order form2_order;
        public Form2(BLAccess bl, Order order)

        {
            this.form2_bl = bl;
            this.form2_order = order;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Close the manager settings window when pressed.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// When clicked, get the date the user entered and show the daily report.
        /// </summary>
        private void DailyReport_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            
            MessageBox.Show(form2_bl.show_report(var));
        }


        /// <summary>
        /// Show the customer bill when pressed
        /// </summary>
        private void BillButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Order Date: " +  form2_order.date + "\n Order Price: " + form2_order.price
                             + "\n Thank you for your purchase");
        }

        /// <summary>
        /// show all the unfinished order.
        /// </summary>
        private void unFinishedButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(form2_bl.showUnfinished_Sales());
             
        }

        /// <summary>
        /// Selector Sql/NoSql database
        /// </summary>
        private void Sql_NoSql (object sender, EventArgs e)
        {
            form2_bl.change_to_noSQL();
            if (noSQLButton.Text.Equals("noSQL"))
            {
                noSQLButton.Text = "SQL";
            }
            else
            {
                noSQLButton.Text = "noSQL";
            }
        }

        /// <summary>
        /// Show the best flavor
        /// </summary>
        private void bestFlavor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showBestSeller(0));
        }

        /// <summary>
        /// Show the best topping
        /// </summary>
        private void bestToppingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showBestSeller(1));
        }

        /// <summary>
        /// Show the best overall seller
        /// </summary>
        private void bestItemButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(form2_bl.showBestSeller(2));
        }



        //show ebd dat report

    }
}
