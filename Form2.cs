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
        private void button2_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            
            MessageBox.Show(form2_bl.show_report(var));
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showUnfinished_Sales());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form2_bl.showBestFlavor());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form2_bl.change_to_noSQL();
        }

        //show ebd dat report

    }
}
