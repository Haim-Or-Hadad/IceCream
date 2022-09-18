using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void from2_load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //report
        private void DailyReport_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            
            MessageBox.Show(form2_bl.show_report(var));
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Order Date: " +  form2_order.date + "\n Order Price: " + form2_order.price
                             + "\n Thank you for your purchase");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Order.)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void unFinishedButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(form2_bl.showUnfinished_Sales());
             
        }

        private void bestFlavor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showBestFlavor());
        }

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showBestTopping());
        }



        //show ebd dat report

    }
}
