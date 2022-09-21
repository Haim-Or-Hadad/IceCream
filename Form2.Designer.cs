namespace IceCreamShop1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.closeButton = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unFinishedButton = new System.Windows.Forms.Button();
            this.bestFlavorButton = new System.Windows.Forms.Button();
            this.noSQLButton = new System.Windows.Forms.Button();
            this.bestToppingButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.DBLabel = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.bestItemButton = new System.Windows.Forms.Button();
            this.sellingStatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.closeButton.Location = new System.Drawing.Point(1083, 575);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(181, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.BackColor = System.Drawing.Color.Bisque;
            this.dailyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportButton.Location = new System.Drawing.Point(501, 414);
            this.dailyReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(160, 39);
            this.dailyReportButton.TabIndex = 3;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = false;
            this.dailyReportButton.Click += new System.EventHandler(this.DailyReport_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.Bisque;
            this.billButton.Location = new System.Drawing.Point(723, 165);
            this.billButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(168, 69);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Current Bill ";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(209, 417);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 34);
            this.textBox1.TabIndex = 5;
            // 
            // unFinishedButton
            // 
            this.unFinishedButton.BackColor = System.Drawing.Color.Bisque;
            this.unFinishedButton.Location = new System.Drawing.Point(723, 249);
            this.unFinishedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unFinishedButton.Name = "unFinishedButton";
            this.unFinishedButton.Size = new System.Drawing.Size(168, 62);
            this.unFinishedButton.TabIndex = 6;
            this.unFinishedButton.Text = "Unfinished Order";
            this.unFinishedButton.UseVisualStyleBackColor = false;
            this.unFinishedButton.Click += new System.EventHandler(this.unFinishedButton_Click);
            // 
            // bestFlavorButton
            // 
            this.bestFlavorButton.BackColor = System.Drawing.Color.PeachPuff;
            this.bestFlavorButton.Location = new System.Drawing.Point(1045, 185);
            this.bestFlavorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bestFlavorButton.Name = "bestFlavorButton";
            this.bestFlavorButton.Size = new System.Drawing.Size(187, 146);
            this.bestFlavorButton.TabIndex = 7;
            this.bestFlavorButton.Text = "Best Falvor";
            this.bestFlavorButton.UseVisualStyleBackColor = false;
            this.bestFlavorButton.Click += new System.EventHandler(this.bestFlavor_Click);
            // 
            // noSQLButton
            // 
            this.noSQLButton.BackColor = System.Drawing.Color.Bisque;
            this.noSQLButton.Location = new System.Drawing.Point(12, 52);
            this.noSQLButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noSQLButton.Name = "noSQLButton";
            this.noSQLButton.Size = new System.Drawing.Size(165, 71);
            this.noSQLButton.TabIndex = 8;
            this.noSQLButton.Text = "noSQL";
            this.noSQLButton.UseVisualStyleBackColor = false;
            this.noSQLButton.Click += new System.EventHandler(this.Sql_NoSql);
            // 
            // bestToppingButton
            // 
            this.bestToppingButton.BackColor = System.Drawing.Color.PeachPuff;
            this.bestToppingButton.Location = new System.Drawing.Point(1045, 44);
            this.bestToppingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bestToppingButton.Name = "bestToppingButton";
            this.bestToppingButton.Size = new System.Drawing.Size(187, 137);
            this.bestToppingButton.TabIndex = 9;
            this.bestToppingButton.Text = "Best Topping";
            this.bestToppingButton.UseVisualStyleBackColor = false;
            this.bestToppingButton.Click += new System.EventHandler(this.bestToppingButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Courier New", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dateLabel.Location = new System.Drawing.Point(5, 423);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(181, 25);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Insert a date";
            // 
            // DBLabel
            // 
            this.DBLabel.AutoSize = true;
            this.DBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DBLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DBLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DBLabel.Location = new System.Drawing.Point(44, 26);
            this.DBLabel.Name = "DBLabel";
            this.DBLabel.Size = new System.Drawing.Size(99, 20);
            this.DBLabel.TabIndex = 11;
            this.DBLabel.Text = "Change DB";
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.BackColor = System.Drawing.Color.Transparent;
            this.exampleLabel.Location = new System.Drawing.Point(208, 454);
            this.exampleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(130, 16);
            this.exampleLabel.TabIndex = 12;
            this.exampleLabel.Text = "Example: 18-09-2022";
            // 
            // bestItemButton
            // 
            this.bestItemButton.BackColor = System.Drawing.Color.PeachPuff;
            this.bestItemButton.Location = new System.Drawing.Point(1045, 335);
            this.bestItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bestItemButton.Name = "bestItemButton";
            this.bestItemButton.Size = new System.Drawing.Size(187, 146);
            this.bestItemButton.TabIndex = 13;
            this.bestItemButton.Text = "Best overall Item";
            this.bestItemButton.UseVisualStyleBackColor = false;
            this.bestItemButton.Click += new System.EventHandler(this.bestItemButton_Click);
            // 
            // sellingStatLabel
            // 
            this.sellingStatLabel.AutoSize = true;
            this.sellingStatLabel.BackColor = System.Drawing.Color.Transparent;
            this.sellingStatLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sellingStatLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sellingStatLabel.Location = new System.Drawing.Point(1042, 9);
            this.sellingStatLabel.Name = "sellingStatLabel";
            this.sellingStatLabel.Size = new System.Drawing.Size(189, 20);
            this.sellingStatLabel.TabIndex = 14;
            this.sellingStatLabel.Text = "Selling statistics";
            this.sellingStatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 638);
            this.Controls.Add(this.sellingStatLabel);
            this.Controls.Add(this.bestItemButton);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.DBLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.bestToppingButton);
            this.Controls.Add(this.noSQLButton);
            this.Controls.Add(this.bestFlavorButton);
            this.Controls.Add(this.unFinishedButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Manager Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unFinishedButton;
        private System.Windows.Forms.Button bestFlavorButton;
        private System.Windows.Forms.Button noSQLButton;
        private System.Windows.Forms.Button bestToppingButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label DBLabel;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Button bestItemButton;
        private System.Windows.Forms.Label sellingStatLabel;
    }
}