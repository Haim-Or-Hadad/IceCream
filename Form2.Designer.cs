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
            this.button1 = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unFinishedButton = new System.Windows.Forms.Button();
            this.bestFlavorButton = new System.Windows.Forms.Button();
            this.noSQLButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.DBLabel = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(812, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.BackColor = System.Drawing.Color.Bisque;
            this.dailyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportButton.Location = new System.Drawing.Point(376, 336);
            this.dailyReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(120, 32);
            this.dailyReportButton.TabIndex = 3;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = false;
            this.dailyReportButton.Click += new System.EventHandler(this.DailyReport_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.Bisque;
            this.billButton.Location = new System.Drawing.Point(542, 134);
            this.billButton.Margin = new System.Windows.Forms.Padding(2);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(126, 56);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Current Bill ";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 339);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unFinishedButton
            // 
            this.unFinishedButton.BackColor = System.Drawing.Color.Bisque;
            this.unFinishedButton.Location = new System.Drawing.Point(542, 202);
            this.unFinishedButton.Margin = new System.Windows.Forms.Padding(2);
            this.unFinishedButton.Name = "unFinishedButton";
            this.unFinishedButton.Size = new System.Drawing.Size(126, 50);
            this.unFinishedButton.TabIndex = 6;
            this.unFinishedButton.Text = "Unfinished Order";
            this.unFinishedButton.UseVisualStyleBackColor = false;
            this.unFinishedButton.Click += new System.EventHandler(this.unFinishedButton_Click);
            // 
            // bestFlavorButton
            // 
            this.bestFlavorButton.BackColor = System.Drawing.Color.PeachPuff;
            this.bestFlavorButton.Location = new System.Drawing.Point(784, 193);
            this.bestFlavorButton.Margin = new System.Windows.Forms.Padding(2);
            this.bestFlavorButton.Name = "bestFlavorButton";
            this.bestFlavorButton.Size = new System.Drawing.Size(140, 119);
            this.bestFlavorButton.TabIndex = 7;
            this.bestFlavorButton.Text = "Best Falvor";
            this.bestFlavorButton.UseVisualStyleBackColor = false;
            this.bestFlavorButton.Click += new System.EventHandler(this.bestFlavor_Click);
            // 
            // noSQLButton
            // 
            this.noSQLButton.BackColor = System.Drawing.Color.Bisque;
            this.noSQLButton.Location = new System.Drawing.Point(9, 42);
            this.noSQLButton.Margin = new System.Windows.Forms.Padding(2);
            this.noSQLButton.Name = "noSQLButton";
            this.noSQLButton.Size = new System.Drawing.Size(124, 58);
            this.noSQLButton.TabIndex = 8;
            this.noSQLButton.Text = "noSQL";
            this.noSQLButton.UseVisualStyleBackColor = false;
            this.noSQLButton.Click += new System.EventHandler(this.Sql_NoSql);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Location = new System.Drawing.Point(784, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 111);
            this.button2.TabIndex = 9;
            this.button2.Text = "Best Topping";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Courier New", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dateLabel.Location = new System.Drawing.Point(4, 344);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(152, 20);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Insert a date";
            // 
            // DBLabel
            // 
            this.DBLabel.AutoSize = true;
            this.DBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DBLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DBLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DBLabel.Location = new System.Drawing.Point(33, 21);
            this.DBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DBLabel.Name = "DBLabel";
            this.DBLabel.Size = new System.Drawing.Size(79, 16);
            this.DBLabel.TabIndex = 11;
            this.DBLabel.Text = "Change DB";
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.BackColor = System.Drawing.Color.Transparent;
            this.exampleLabel.Location = new System.Drawing.Point(156, 369);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(107, 13);
            this.exampleLabel.TabIndex = 12;
            this.exampleLabel.Text = "Example: 18-09-2022";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 518);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.DBLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.noSQLButton);
            this.Controls.Add(this.bestFlavorButton);
            this.Controls.Add(this.unFinishedButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Manager Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unFinishedButton;
        private System.Windows.Forms.Button bestFlavorButton;
        private System.Windows.Forms.Button noSQLButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label DBLabel;
        private System.Windows.Forms.Label exampleLabel;
    }
}