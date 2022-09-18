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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(1083, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dailyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportButton.Location = new System.Drawing.Point(480, 359);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(160, 39);
            this.dailyReportButton.TabIndex = 3;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = false;
            this.dailyReportButton.Click += new System.EventHandler(this.DailyReport_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(723, 165);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(168, 69);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Current Bill ";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(182, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unFinishedButton
            // 
            this.unFinishedButton.Location = new System.Drawing.Point(723, 249);
            this.unFinishedButton.Name = "unFinishedButton";
            this.unFinishedButton.Size = new System.Drawing.Size(168, 61);
            this.unFinishedButton.TabIndex = 6;
            this.unFinishedButton.Text = "Unfinished Order";
            this.unFinishedButton.UseVisualStyleBackColor = true;
            this.unFinishedButton.Click += new System.EventHandler(this.unFinishedButton_Click);
            // 
            // bestFlavorButton
            // 
            this.bestFlavorButton.BackColor = System.Drawing.Color.PeachPuff;
            this.bestFlavorButton.Location = new System.Drawing.Point(1046, 237);
            this.bestFlavorButton.Name = "bestFlavorButton";
            this.bestFlavorButton.Size = new System.Drawing.Size(187, 147);
            this.bestFlavorButton.TabIndex = 7;
            this.bestFlavorButton.Text = "Best Falvor";
            this.bestFlavorButton.UseVisualStyleBackColor = false;
            this.bestFlavorButton.Click += new System.EventHandler(this.bestFlavor_Click);
            // 
            // noSQLButton
            // 
            this.noSQLButton.Location = new System.Drawing.Point(12, 12);
            this.noSQLButton.Name = "noSQLButton";
            this.noSQLButton.Size = new System.Drawing.Size(166, 72);
            this.noSQLButton.TabIndex = 8;
            this.noSQLButton.Text = "noSQL";
            this.noSQLButton.UseVisualStyleBackColor = true;
            this.noSQLButton.Click += new System.EventHandler(this.Sql_NoSql);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Location = new System.Drawing.Point(1046, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 137);
            this.button2.TabIndex = 9;
            this.button2.Text = "Best Topping";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "insert a date";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.noSQLButton);
            this.Controls.Add(this.bestFlavorButton);
            this.Controls.Add(this.unFinishedButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showReportButton;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unFinishedButton;
        private System.Windows.Forms.Button bestFlavorButton;
        private System.Windows.Forms.Button noSQLButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}