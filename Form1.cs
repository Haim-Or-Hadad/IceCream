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
        Order order;

        
        public Form1()
        {
            InitializeComponent();
        }

        public void ClientOrder()
        {
            order = newBl.newOrder();
            button1.Click += (sender, e) => choose_Cup(sender, e);

        }

        private void choose_Cup(object sender, System.EventArgs e)
        {
            Cups cup = new Cups();
            if (regular.Checked)
            {
                special.Enabled = false;
                box.Enabled = false;
                cup = Cups.Reagular;
            }
            else if (special.Checked)
            {
                regular.Enabled = false;
                box.Enabled = false;
                cup = Cups.Special;
            }
            else
            {
                regular.Enabled = false;
                special.Enabled = false;
                cup = Cups.Box;
            }
            this.order.chooseCup(cup);
            Console.WriteLine(cup.ToString());
        }


        void run()
        {
            ClientOrder();
            string[] vars = Enum.GetNames(typeof(Toppings));
            foreach (string enumValue in vars)
            {
                this.toppingListbox.Items.Add(enumValue);
            }
            this.ShowDialog();
;        }
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            form.run();
        }


        /// <summary>
        /// Function that add the toppings picked frim the topping list box
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_top = this.toppingListbox.SelectedItem.ToString();
                this.order.addTop((Toppings)Enum.Parse(typeof(Toppings), selected_top));
                this.order_summary.Items.Add(selected_top);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The main function for the flavor buttons.
        /// add the selected flavor to the order and display it in the Order summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flavor_button_Click(object sender, EventArgs e)
        {
            try
            {
                string choosen_flavor = ((Button)sender).Text;
                this.order.addFlavor((Flavor)Enum.Parse(typeof(Flavor), choosen_flavor));
                this.order_summary.Items.Add(choosen_flavor);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selected_flavor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //no use delete later
        }

        /// <summary>
        /// Rest the order
        /// </summary>
        private void rest_button_Click(object sender, EventArgs e)
        {
            this.order.price = -1;
            newBl.insertOrder(order);
            reset_order(order);
        }

        private void proceed_button_click(object sender, EventArgs e)
        {
            newBl.insertOrder(order);
            reset_order(order);
        }

        public void reset_order(Order order)
        {
            this.order = newBl.newOrder();
            this.order_summary.Items.Clear();
            this.regular.Enabled = true;
            this.special.Enabled = true;
            this.box.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            newBl.initDB();
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(newBl,order);
            
            newform.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    } 
        

}
