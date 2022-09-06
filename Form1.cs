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
            button1.Click += (sender, e) => choose_Cup(sender, e, order);
            button2.Click += (sender, e) => flavorsType(sender, e, order);

        }

        void flavorsType(Object sender, EventArgs e , Order order)
        {
            List<Flavor> flavors = new List<Flavor>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string str = checkedListBox1.CheckedItems[i].ToString();
                order.addFlavor((Flavor)Enum.Parse(typeof(Flavor), str));
                Console.WriteLine(str);
            }  
        }
        private void choose_Cup(object sender, System.EventArgs e , Order order)
        {
            Cups cup = new Cups();
            if (reagular.Checked)
            {
                special.Enabled = false;
                box.Enabled = false;
                cup = Cups.Reagular;
            }
            else if (special.Checked)
            {
                reagular.Enabled = false;
                box.Enabled = false;
                cup = Cups.Special;
            }
            else
            {
                reagular.Enabled = false;
                special.Enabled = false;
                cup = Cups.Box;
            }
            order.chooseCup(cup);
            Console.WriteLine(cup.ToString());
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
            ClientOrder();
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




    }

}
