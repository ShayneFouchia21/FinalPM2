namespace Final_PM2
{
    partial class PrintInvoice
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
            System.Windows.Forms.Label invoice_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label total_PriceLabel;
            this.headerLbl = new System.Windows.Forms.Label();
            this.outputIDLbl = new System.Windows.Forms.Label();
            this.outputNameLbl = new System.Windows.Forms.Label();
            this.outputDateLbl = new System.Windows.Forms.Label();
            this.outputTotalLbl = new System.Windows.Forms.Label();
            invoice_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            total_PriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(193, 9);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(191, 25);
            this.headerLbl.TabIndex = 5;
            this.headerLbl.Text = "Joe\'s Automotive";
            // 
            // invoice_IDLabel
            // 
            invoice_IDLabel.AutoSize = true;
            invoice_IDLabel.Location = new System.Drawing.Point(77, 121);
            invoice_IDLabel.Name = "invoice_IDLabel";
            invoice_IDLabel.Size = new System.Drawing.Size(59, 13);
            invoice_IDLabel.TabIndex = 6;
            invoice_IDLabel.Text = "Invoice ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(77, 179);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(77, 226);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // total_PriceLabel
            // 
            total_PriceLabel.AutoSize = true;
            total_PriceLabel.Location = new System.Drawing.Point(77, 274);
            total_PriceLabel.Name = "total_PriceLabel";
            total_PriceLabel.Size = new System.Drawing.Size(61, 13);
            total_PriceLabel.TabIndex = 9;
            total_PriceLabel.Text = "Total Price:";
            // 
            // outputIDLbl
            // 
            this.outputIDLbl.AutoSize = true;
            this.outputIDLbl.Location = new System.Drawing.Point(212, 121);
            this.outputIDLbl.Name = "outputIDLbl";
            this.outputIDLbl.Size = new System.Drawing.Size(0, 13);
            this.outputIDLbl.TabIndex = 10;
            // 
            // outputNameLbl
            // 
            this.outputNameLbl.AutoSize = true;
            this.outputNameLbl.Location = new System.Drawing.Point(212, 179);
            this.outputNameLbl.Name = "outputNameLbl";
            this.outputNameLbl.Size = new System.Drawing.Size(0, 13);
            this.outputNameLbl.TabIndex = 11;
            // 
            // outputDateLbl
            // 
            this.outputDateLbl.AutoSize = true;
            this.outputDateLbl.Location = new System.Drawing.Point(212, 226);
            this.outputDateLbl.Name = "outputDateLbl";
            this.outputDateLbl.Size = new System.Drawing.Size(0, 13);
            this.outputDateLbl.TabIndex = 12;
            // 
            // outputTotalLbl
            // 
            this.outputTotalLbl.AutoSize = true;
            this.outputTotalLbl.Location = new System.Drawing.Point(212, 274);
            this.outputTotalLbl.Name = "outputTotalLbl";
            this.outputTotalLbl.Size = new System.Drawing.Size(0, 13);
            this.outputTotalLbl.TabIndex = 13;
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 535);
            this.Controls.Add(this.outputTotalLbl);
            this.Controls.Add(this.outputDateLbl);
            this.Controls.Add(this.outputNameLbl);
            this.Controls.Add(this.outputIDLbl);
            this.Controls.Add(total_PriceLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(invoice_IDLabel);
            this.Controls.Add(this.headerLbl);
            this.Name = "PrintInvoice";
            this.Text = "PrintInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label outputIDLbl;
        private System.Windows.Forms.Label outputNameLbl;
        private System.Windows.Forms.Label outputDateLbl;
        private System.Windows.Forms.Label outputTotalLbl;
    }
}