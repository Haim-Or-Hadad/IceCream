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
            this.button1 = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unFinishedButton = new System.Windows.Forms.Button();
            this.bestFlavorButton = new System.Windows.Forms.Button();
            this.noSQLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.Location = new System.Drawing.Point(12, 70);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(166, 63);
            this.dailyReportButton.TabIndex = 3;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = true;
            this.dailyReportButton.Click += new System.EventHandler(this.DailyReport_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(215, 70);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(160, 63);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Current Bill ";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unFinishedButton
            // 
            this.unFinishedButton.Location = new System.Drawing.Point(414, 74);
            this.unFinishedButton.Name = "unFinishedButton";
            this.unFinishedButton.Size = new System.Drawing.Size(189, 59);
            this.unFinishedButton.TabIndex = 6;
            this.unFinishedButton.Text = "Unfinished Order";
            this.unFinishedButton.UseVisualStyleBackColor = true;
            // 
            // bestFlavorButton
            // 
            this.bestFlavorButton.Location = new System.Drawing.Point(646, 74);
            this.bestFlavorButton.Name = "bestFlavorButton";
            this.bestFlavorButton.Size = new System.Drawing.Size(128, 68);
            this.bestFlavorButton.TabIndex = 7;
            this.bestFlavorButton.Text = "Best Falvor";
            this.bestFlavorButton.UseVisualStyleBackColor = true;
            this.bestFlavorButton.Click += new System.EventHandler(this.bestFlavor_Click);
            // 
            // noSQLButton
            // 
            this.noSQLButton.Location = new System.Drawing.Point(12, 167);
            this.noSQLButton.Name = "noSQLButton";
            this.noSQLButton.Size = new System.Drawing.Size(128, 54);
            this.noSQLButton.TabIndex = 8;
            this.noSQLButton.Text = "noSQL";
            this.noSQLButton.UseVisualStyleBackColor = true;
            this.noSQLButton.Click += new System.EventHandler(this.Sql_NoSql);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}