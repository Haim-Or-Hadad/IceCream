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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.regular = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.box = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.toppingListbox = new System.Windows.Forms.ListBox();
            this.rest_button = new System.Windows.Forms.Button();
            this.proceed_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(343, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.choose_Cup);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 233);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add topping";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.BackColor = System.Drawing.Color.Bisque;
            this.regular.Location = new System.Drawing.Point(381, 166);
            this.regular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(70, 20);
            this.regular.TabIndex = 4;
            this.regular.TabStop = true;
            this.regular.Text = "regular";
            this.regular.UseVisualStyleBackColor = false;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.BackColor = System.Drawing.Color.Bisque;
            this.special.Location = new System.Drawing.Point(381, 192);
            this.special.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(72, 20);
            this.special.TabIndex = 5;
            this.special.TabStop = true;
            this.special.Text = "special";
            this.special.UseVisualStyleBackColor = false;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.BackColor = System.Drawing.Color.Bisque;
            this.box.Location = new System.Drawing.Point(381, 217);
            this.box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(50, 20);
            this.box.TabIndex = 6;
            this.box.TabStop = true;
            this.box.Text = "box";
            this.box.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Flavors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(786, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Topping";
            // 
            // chocolate_button
            // 
            this.chocolate_button.BackColor = System.Drawing.Color.PeachPuff;
            this.chocolate_button.Location = new System.Drawing.Point(567, 80);
            this.chocolate_button.Name = "chocolate_button";
            this.chocolate_button.Size = new System.Drawing.Size(92, 23);
            this.chocolate_button.TabIndex = 12;
            this.chocolate_button.Text = "Chocolate";
            this.chocolate_button.UseVisualStyleBackColor = false;
            this.chocolate_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // strawberry_button
            // 
            this.strawberry_button.BackColor = System.Drawing.Color.PeachPuff;
            this.strawberry_button.Location = new System.Drawing.Point(567, 109);
            this.strawberry_button.Name = "strawberry_button";
            this.strawberry_button.Size = new System.Drawing.Size(92, 23);
            this.strawberry_button.TabIndex = 13;
            this.strawberry_button.Text = "Strawberry";
            this.strawberry_button.UseVisualStyleBackColor = false;
            this.strawberry_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // vanilla_button
            // 
            this.vanilla_button.BackColor = System.Drawing.Color.PeachPuff;
            this.vanilla_button.Location = new System.Drawing.Point(567, 138);
            this.vanilla_button.Name = "vanilla_button";
            this.vanilla_button.Size = new System.Drawing.Size(92, 23);
            this.vanilla_button.TabIndex = 14;
            this.vanilla_button.Text = "Vanilla";
            this.vanilla_button.UseVisualStyleBackColor = false;
            this.vanilla_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // banana_button
            // 
            this.banana_button.BackColor = System.Drawing.Color.PeachPuff;
            this.banana_button.Location = new System.Drawing.Point(567, 167);
            this.banana_button.Name = "banana_button";
            this.banana_button.Size = new System.Drawing.Size(92, 23);
            this.banana_button.TabIndex = 15;
            this.banana_button.Text = "Banana";
            this.banana_button.UseVisualStyleBackColor = false;
            this.banana_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mango_button
            // 
            this.mango_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mango_button.Location = new System.Drawing.Point(567, 196);
            this.mango_button.Name = "mango_button";
            this.mango_button.Size = new System.Drawing.Size(92, 23);
            this.mango_button.TabIndex = 16;
            this.mango_button.Text = "Mango";
            this.mango_button.UseVisualStyleBackColor = false;
            this.mango_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // coconut_button
            // 
            this.coconut_button.BackColor = System.Drawing.Color.PeachPuff;
            this.coconut_button.Location = new System.Drawing.Point(567, 225);
            this.coconut_button.Name = "coconut_button";
            this.coconut_button.Size = new System.Drawing.Size(92, 23);
            this.coconut_button.TabIndex = 17;
            this.coconut_button.Text = "Coconut";
            this.coconut_button.UseVisualStyleBackColor = false;
            this.coconut_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // matcha_button
            // 
            this.matcha_button.BackColor = System.Drawing.Color.PeachPuff;
            this.matcha_button.Location = new System.Drawing.Point(567, 254);
            this.matcha_button.Name = "matcha_button";
            this.matcha_button.Size = new System.Drawing.Size(92, 23);
            this.matcha_button.TabIndex = 18;
            this.matcha_button.Text = "Matcha";
            this.matcha_button.UseVisualStyleBackColor = false;
            this.matcha_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // pistachio_button
            // 
            this.pistachio_button.BackColor = System.Drawing.Color.PeachPuff;
            this.pistachio_button.Location = new System.Drawing.Point(567, 283);
            this.pistachio_button.Name = "pistachio_button";
            this.pistachio_button.Size = new System.Drawing.Size(92, 23);
            this.pistachio_button.TabIndex = 19;
            this.pistachio_button.Text = "Pistachio";
            this.pistachio_button.UseVisualStyleBackColor = false;
            this.pistachio_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mikopelet_button
            // 
            this.mikopelet_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mikopelet_button.Location = new System.Drawing.Point(567, 312);
            this.mikopelet_button.Name = "mikopelet_button";
            this.mikopelet_button.Size = new System.Drawing.Size(92, 23);
            this.mikopelet_button.TabIndex = 20;
            this.mikopelet_button.Text = "Mikopelet";
            this.mikopelet_button.UseVisualStyleBackColor = false;
            this.mikopelet_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // mint_button
            // 
            this.mint_button.BackColor = System.Drawing.Color.PeachPuff;
            this.mint_button.Location = new System.Drawing.Point(567, 341);
            this.mint_button.Name = "mint_button";
            this.mint_button.Size = new System.Drawing.Size(92, 23);
            this.mint_button.TabIndex = 21;
            this.mint_button.Text = "Mint";
            this.mint_button.UseVisualStyleBackColor = false;
            this.mint_button.Click += new System.EventHandler(this.flavor_button_Click);
            // 
            // order_summary
            // 
            this.order_summary.FormattingEnabled = true;
            this.order_summary.ItemHeight = 16;
            this.order_summary.Location = new System.Drawing.Point(1063, 64);
            this.order_summary.Name = "order_summary";
            this.order_summary.Size = new System.Drawing.Size(181, 308);
            this.order_summary.TabIndex = 22;
            this.order_summary.SelectedIndexChanged += new System.EventHandler(this.selected_flavor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1059, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Order summary";
            // 
            // toppingListbox
            // 
            this.toppingListbox.FormattingEnabled = true;
            this.toppingListbox.ItemHeight = 16;
            this.toppingListbox.Location = new System.Drawing.Point(740, 123);
            this.toppingListbox.Name = "toppingListbox";
            this.toppingListbox.Size = new System.Drawing.Size(213, 100);
            this.toppingListbox.TabIndex = 24;
            // 
            // rest_button
            // 
            this.rest_button.Location = new System.Drawing.Point(942, 361);
            this.rest_button.Name = "rest_button";
            this.rest_button.Size = new System.Drawing.Size(81, 36);
            this.rest_button.TabIndex = 25;
            this.rest_button.Text = "Rest";
            this.rest_button.UseVisualStyleBackColor = true;
            this.rest_button.Click += new System.EventHandler(this.rest_button_Click);
            // 
            // proceed_button
            // 
            this.proceed_button.Location = new System.Drawing.Point(1109, 378);
            this.proceed_button.Name = "proceed_button";
            this.proceed_button.Size = new System.Drawing.Size(75, 23);
            this.proceed_button.TabIndex = 26;
            this.proceed_button.Text = "proceed";
            this.proceed_button.UseVisualStyleBackColor = true;
            this.proceed_button.Click += new System.EventHandler(this.proceed_button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 54);
            this.button4.TabIndex = 29;
            this.button4.Text = "worker";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1285, 642);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.proceed_button);
            this.Controls.Add(this.rest_button);
            this.Controls.Add(this.toppingListbox);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box);
            this.Controls.Add(this.special);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton regular;
        private System.Windows.Forms.RadioButton special;
        private System.Windows.Forms.RadioButton box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox toppingListbox;
        private System.Windows.Forms.Button rest_button;
        private System.Windows.Forms.Button proceed_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

