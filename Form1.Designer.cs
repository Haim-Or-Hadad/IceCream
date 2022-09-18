namespace IceCreamShop1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addCupButton = new System.Windows.Forms.Button();
            this.addToppingButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.regular = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.box = new System.Windows.Forms.RadioButton();
            this.cupLabel = new System.Windows.Forms.Label();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.chocolate_button = new System.Windows.Forms.Button();
            this.strawberry_button = new System.Windows.Forms.Button();
            this.vanilla_button = new System.Windows.Forms.Button();
            this.banana_button = new System.Windows.Forms.Button();
            this.mango_button = new System.Windows.Forms.Button();
            this.coconut_button = new System.Windows.Forms.Button();
            this.matcha_button = new System.Windows.Forms.Button();
            this.pistachio_button = new System.Windows.Forms.Button();
            this.mikopelet_button = new System.Windows.Forms.Button();
            this.mint_button = new System.Windows.Forms.Button();
            this.order_summary = new System.Windows.Forms.ListBox();
            this.orderSumLabel = new System.Windows.Forms.Label();
            this.toppingListbox = new System.Windows.Forms.ListBox();
            this.rest_button = new System.Windows.Forms.Button();
            this.finish_button = new System.Windows.Forms.Button();
            this.initDBButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCupButton
            // 
            this.addCupButton.BackColor = System.Drawing.Color.Bisque;
            this.addCupButton.Location = new System.Drawing.Point(254, 238);
            this.addCupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCupButton.Name = "addCupButton";
            this.addCupButton.Size = new System.Drawing.Size(103, 41);
            this.addCupButton.TabIndex = 0;
            this.addCupButton.Text = "Select cup";
            this.addCupButton.UseVisualStyleBackColor = false;
            this.addCupButton.Click += new System.EventHandler(this.choose_Cup);
            // 
            // addToppingButton
            // 
            this.addToppingButton.BackColor = System.Drawing.Color.Bisque;
            this.addToppingButton.Location = new System.Drawing.Point(591, 252);
            this.addToppingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addToppingButton.Name = "addToppingButton";
            this.addToppingButton.Size = new System.Drawing.Size(81, 37);
            this.addToppingButton.TabIndex = 2;
            this.addToppingButton.Text = "Add topping";
            this.addToppingButton.UseVisualStyleBackColor = false;
            this.addToppingButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.BackColor = System.Drawing.Color.Bisque;
            this.regular.Location = new System.Drawing.Point(280, 165);
            this.regular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(62, 17);
            this.regular.TabIndex = 4;
            this.regular.TabStop = true;
            this.regular.Text = "Regular";
            this.regular.UseVisualStyleBackColor = false;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.BackColor = System.Drawing.Color.Bisque;
            this.special.Location = new System.Drawing.Point(280, 186);
            this.special.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(60, 17);
            this.special.TabIndex = 5;
            this.special.TabStop = true;
            this.special.Text = "Special";
            this.special.UseVisualStyleBackColor = false;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.BackColor = System.Drawing.Color.Bisque;
            this.box.Location = new System.Drawing.Point(280, 206);
            this.box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(43, 17);
            this.box.TabIndex = 6;
            this.box.TabStop = true;
            this.box.Text = "Box";
            this.box.UseVisualStyleBackColor = false;
            // 
            // cupLabel
            // 
            this.cupLabel.AutoSize = true;
            this.cupLabel.BackColor = System.Drawing.Color.Transparent;
            this.cupLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupLabel.Location = new System.Drawing.Point(290, 134);
            this.cupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cupLabel.Name = "cupLabel";
            this.cupLabel.Size = new System.Drawing.Size(37, 18);
            this.cupLabel.TabIndex = 7;
            this.cupLabel.Text = "Cup";
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.BackColor = System.Drawing.Color.Transparent;
            this.flavorLabel.Enabled = false;
            this.flavorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavorLabel.Location = new System.Drawing.Point(431, 89);
            this.flavorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(59, 18);
            this.flavorLabel.TabIndex = 10;
            this.flavorLabel.Text = "Flavors";
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.BackColor = System.Drawing.Color.Transparent;
            this.toppingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingLabel.Location = new System.Drawing.Point(597, 134);
            this.toppingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(63, 18);
            this.toppingLabel.TabIndex = 10;
            this.toppingLabel.Text = "Topping";
            // 
            // chocolate_button
            // 
            this.chocolate_button.BackColor = System.Drawing.Color.PeachPuff;
            this.chocolate_button.Location = new System.Drawing.Point(425, 117);
            this.chocolate_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chocolate_button.Name = "chocolate_button";
            this.chocolate_button.Size = new System.Drawing.Size(69, 19);
            this.chocolate_button.TabIndex = 12;
            this.chocolate_button.Text = "Chocolate";
            this.chocolate_button.UseVisualStyleBackColor = false;
            this.chocolate_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // strawberry_button
            // 
            this.strawberry_button.BackColor = System.Drawing.Color.PeachPuff;
            this.strawberry_button.Location = new System.Drawing.Point(425, 141);
            this.strawberry_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strawberry_button.Name = "strawberry_button";
            this.strawberry_button.Size = new System.Drawing.Size(69, 19);
            this.strawberry_button.TabIndex = 13;
            this.strawberry_button.Text = "Strawberry";
            this.strawberry_button.UseVisualStyleBackColor = false;
            this.strawberry_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // vanilla_button
            // 
            this.vanilla_button.BackColor = System.Drawing.Color.PeachPuff;
            this.vanilla_button.Location = new System.Drawing.Point(425, 164);
            this.vanilla_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vanilla_button.Name = "vanilla_button";
            this.vanilla_button.Size = new System.Drawing.Size(69, 19);
            this.vanilla_button.TabIndex = 14;
            this.vanilla_button.Text = "Vanilla";
            this.vanilla_button.UseVisualStyleBackColor = false;
            this.vanilla_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // banana_button
            // 
            this.banana_button.BackColor = System.Drawing.Color.PeachPuff;
            this.banana_button.Location = new System.Drawing.Point(425, 188);
            this.banana_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.banana_button.Name = "banana_button";
            this.banana_button.Size = new System.Drawing.Size(69, 19);
            this.banana_button.TabIndex = 15;
            this.banana_button.Text = "Banana";
            this.banana_button.UseVisualStyleBackColor = false;
            this.banana_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mango_button
            // 
            this.mango_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mango_button.Location = new System.Drawing.Point(425, 211);
            this.mango_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(69, 19);
            this.mango_button.TabIndex = 16;
            this.mango_button.Text = "Mango";
            this.mango_button.UseVisualStyleBackColor = false;
            this.mango_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // coconut_button
            // 
            this.coconut_button.BackColor = System.Drawing.Color.PeachPuff;
            this.coconut_button.Location = new System.Drawing.Point(425, 235);
            this.coconut_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coconut_button.Name = "coconut_button";
            this.coconut_button.Size = new System.Drawing.Size(69, 19);
            this.coconut_button.TabIndex = 17;
            this.coconut_button.Text = "Coconut";
            this.coconut_button.UseVisualStyleBackColor = false;
            this.coconut_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // matcha_button
            // 
            this.matcha_button.BackColor = System.Drawing.Color.PeachPuff;
            this.matcha_button.Location = new System.Drawing.Point(425, 258);
            this.matcha_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matcha_button.Name = "matcha_button";
            this.matcha_button.Size = new System.Drawing.Size(69, 19);
            this.matcha_button.TabIndex = 18;
            this.matcha_button.Text = "Matcha";
            this.matcha_button.UseVisualStyleBackColor = false;
            this.matcha_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // pistachio_button
            // 
            this.pistachio_button.BackColor = System.Drawing.Color.PeachPuff;
            this.pistachio_button.Location = new System.Drawing.Point(425, 282);
            this.pistachio_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pistachio_button.Name = "pistachio_button";
            this.pistachio_button.Size = new System.Drawing.Size(69, 19);
            this.pistachio_button.TabIndex = 19;
            this.pistachio_button.Text = "Pistachio";
            this.pistachio_button.UseVisualStyleBackColor = false;
            this.pistachio_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mikopelet_button
            // 
            this.mikopelet_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mikopelet_button.Location = new System.Drawing.Point(425, 306);
            this.mikopelet_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mikopelet_button.Name = "mikopelet_button";
            this.mikopelet_button.Size = new System.Drawing.Size(69, 19);
            this.mikopelet_button.TabIndex = 20;
            this.mikopelet_button.Text = "Mikopelet";
            this.mikopelet_button.UseVisualStyleBackColor = false;
            this.mikopelet_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mint_button
            // 
            this.mint_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mint_button.Location = new System.Drawing.Point(425, 330);
            this.mint_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mint_button.Name = "mint_button";
            this.mint_button.Size = new System.Drawing.Size(69, 19);
            this.mint_button.TabIndex = 21;
            this.mint_button.Text = "Mint";
            this.mint_button.UseVisualStyleBackColor = false;
            this.mint_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // order_summary
            // 
            this.order_summary.FormattingEnabled = true;
            this.order_summary.Location = new System.Drawing.Point(794, 102);
            this.order_summary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.order_summary.Name = "order_summary";
            this.order_summary.Size = new System.Drawing.Size(139, 251);
            this.order_summary.TabIndex = 22;
            this.order_summary.SelectedIndexChanged += new System.EventHandler(this.selected_flavor_SelectedIndexChanged);
            // 
            // orderSumLabel
            // 
            this.orderSumLabel.AutoSize = true;
            this.orderSumLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderSumLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSumLabel.Location = new System.Drawing.Point(808, 75);
            this.orderSumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSumLabel.Name = "orderSumLabel";
            this.orderSumLabel.Size = new System.Drawing.Size(115, 18);
            this.orderSumLabel.TabIndex = 23;
            this.orderSumLabel.Text = "Order summary";
            // 
            // toppingListbox
            // 
            this.toppingListbox.FormattingEnabled = true;
            this.toppingListbox.Location = new System.Drawing.Point(553, 163);
            this.toppingListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppingListbox.Name = "toppingListbox";
            this.toppingListbox.Size = new System.Drawing.Size(161, 82);
            this.toppingListbox.TabIndex = 24;
            // 
            // rest_button
            // 
            this.rest_button.BackColor = System.Drawing.Color.Bisque;
            this.rest_button.Location = new System.Drawing.Point(778, 357);
            this.rest_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rest_button.Name = "rest_button";
            this.rest_button.Size = new System.Drawing.Size(73, 24);
            this.rest_button.TabIndex = 26;
            this.rest_button.Text = "Rest Order";
            this.rest_button.UseVisualStyleBackColor = false;
            this.rest_button.Click += new System.EventHandler(this.rest_button_Click);
            // 
            // finish_button
            // 
            this.finish_button.BackColor = System.Drawing.Color.Bisque;
            this.finish_button.Location = new System.Drawing.Point(855, 357);
            this.finish_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(78, 24);
            this.finish_button.TabIndex = 26;
            this.finish_button.Text = "Finish Order";
            this.finish_button.UseVisualStyleBackColor = false;
            this.finish_button.Click += new System.EventHandler(this.proceed_button_click);
            // 
            // initDBButton
            // 
            this.initDBButton.BackColor = System.Drawing.Color.Bisque;
            this.initDBButton.Location = new System.Drawing.Point(9, 15);
            this.initDBButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.initDBButton.Name = "initDBButton";
            this.initDBButton.Size = new System.Drawing.Size(68, 41);
            this.initDBButton.TabIndex = 28;
            this.initDBButton.Text = "Initialize DB";
            this.initDBButton.UseVisualStyleBackColor = false;
            this.initDBButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.PeachPuff;
            this.managerButton.Location = new System.Drawing.Point(9, 277);
            this.managerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(107, 44);
            this.managerButton.TabIndex = 29;
            this.managerButton.Text = "Manager Settings";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 522);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.initDBButton);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.rest_button);
            this.Controls.Add(this.toppingListbox);
            this.Controls.Add(this.orderSumLabel);
            this.Controls.Add(this.order_summary);
            this.Controls.Add(this.mint_button);
            this.Controls.Add(this.mikopelet_button);
            this.Controls.Add(this.pistachio_button);
            this.Controls.Add(this.matcha_button);
            this.Controls.Add(this.coconut_button);
            this.Controls.Add(this.mango_button);
            this.Controls.Add(this.banana_button);
            this.Controls.Add(this.vanilla_button);
            this.Controls.Add(this.strawberry_button);
            this.Controls.Add(this.chocolate_button);
            this.Controls.Add(this.toppingLabel);
            this.Controls.Add(this.flavorLabel);
            this.Controls.Add(this.cupLabel);
            this.Controls.Add(this.box);
            this.Controls.Add(this.special);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.addToppingButton);
            this.Controls.Add(this.addCupButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Ice Cream Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCupButton;
        private System.Windows.Forms.Button addToppingButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton regular;
        private System.Windows.Forms.RadioButton special;
        private System.Windows.Forms.RadioButton box;
        private System.Windows.Forms.Label cupLabel;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.Button chocolate_button;
        private System.Windows.Forms.Button strawberry_button;
        private System.Windows.Forms.Button vanilla_button;
        private System.Windows.Forms.Button banana_button;
        private System.Windows.Forms.Button mango_button;
        private System.Windows.Forms.Button coconut_button;
        private System.Windows.Forms.Button matcha_button;
        private System.Windows.Forms.Button pistachio_button;
        private System.Windows.Forms.Button mikopelet_button;
        private System.Windows.Forms.Button mint_button;
        private System.Windows.Forms.ListBox order_summary;
        private System.Windows.Forms.Label orderSumLabel;
        private System.Windows.Forms.ListBox toppingListbox;
        private System.Windows.Forms.Button rest_button;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.Button initDBButton;
        private System.Windows.Forms.Button managerButton;
    }
}

