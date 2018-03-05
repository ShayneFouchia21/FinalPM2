namespace Final_PM2
{
    partial class Main
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
            this.customerBttn = new System.Windows.Forms.Button();
            this.partsBttn = new System.Windows.Forms.Button();
            this.vehicleBttn = new System.Windows.Forms.Button();
            this.invoiceBttn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerBttn
            // 
            this.customerBttn.Location = new System.Drawing.Point(115, 126);
            this.customerBttn.Name = "customerBttn";
            this.customerBttn.Size = new System.Drawing.Size(126, 60);
            this.customerBttn.TabIndex = 0;
            this.customerBttn.Text = "Customer";
            this.customerBttn.UseVisualStyleBackColor = true;
            this.customerBttn.Click += new System.EventHandler(this.customerBttn_Click);
            // 
            // partsBttn
            // 
            this.partsBttn.Location = new System.Drawing.Point(115, 217);
            this.partsBttn.Name = "partsBttn";
            this.partsBttn.Size = new System.Drawing.Size(126, 60);
            this.partsBttn.TabIndex = 1;
            this.partsBttn.Text = "Parts";
            this.partsBttn.UseVisualStyleBackColor = true;
            this.partsBttn.Click += new System.EventHandler(this.partsBttn_Click);
            // 
            // vehicleBttn
            // 
            this.vehicleBttn.Location = new System.Drawing.Point(316, 217);
            this.vehicleBttn.Name = "vehicleBttn";
            this.vehicleBttn.Size = new System.Drawing.Size(126, 60);
            this.vehicleBttn.TabIndex = 2;
            this.vehicleBttn.Text = "Vehicle";
            this.vehicleBttn.UseVisualStyleBackColor = true;
            this.vehicleBttn.Click += new System.EventHandler(this.vehicleBttn_Click);
            // 
            // invoiceBttn
            // 
            this.invoiceBttn.Location = new System.Drawing.Point(316, 126);
            this.invoiceBttn.Name = "invoiceBttn";
            this.invoiceBttn.Size = new System.Drawing.Size(126, 60);
            this.invoiceBttn.TabIndex = 3;
            this.invoiceBttn.Text = "Invoices";
            this.invoiceBttn.UseVisualStyleBackColor = true;
            this.invoiceBttn.Click += new System.EventHandler(this.invoiceBttn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(180, 57);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(191, 25);
            this.headerLbl.TabIndex = 4;
            this.headerLbl.Text = "Joe\'s Automotive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select which category";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(575, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.invoiceBttn);
            this.Controls.Add(this.vehicleBttn);
            this.Controls.Add(this.partsBttn);
            this.Controls.Add(this.customerBttn);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerBttn;
        private System.Windows.Forms.Button partsBttn;
        private System.Windows.Forms.Button vehicleBttn;
        private System.Windows.Forms.Button invoiceBttn;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label label1;
    }
}

