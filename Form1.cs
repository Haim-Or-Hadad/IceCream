using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IcecreamMenu;
using BusinessLogic;


namespace IceCreamShop1
{
    public partial class Form1 : Form
    {
        BLAccess newBl = new BLAccess();
        public Form1()
        {
            InitializeComponent();
        }

        public void ClientOrder()
        {
            Order order = newBl.newOrder();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox1.SelectedItem.ToString();
        }

        void run()
        {
            Form1 form = new Form1();
            string []vars = Enum.GetNames(typeof(Flavor));
            foreach (string enumValue in vars)
            {
                form.checkedListBox1.Items.Add(enumValue, CheckState.Unchecked);
            }
            vars = Enum.GetNames(typeof(Toppings));
            foreach (string enumValue in vars)
            {
                form.checkedListBox2.Items.Add(enumValue, CheckState.Unchecked);
            }
            form.ShowDialog();
;        }
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            form.run();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Contains("maple"))
            {
                MessageBox.Show("yess!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (string item in checkedListBox2.CheckedItems)
            {
                MessageBox.Show(item);
            }
            for(int i =0; i <checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.Enabled = false;
            }

            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (reagular.Checked)
            {
                special.Enabled = false;
                box.Enabled = false;
            }
            else if (special.Checked)
            {
                reagular.Enabled = false;
                box.Enabled = false;
            }
            else
            {
                reagular.Enabled = false;
                special.Enabled = false;
            }
        }
    }

}
