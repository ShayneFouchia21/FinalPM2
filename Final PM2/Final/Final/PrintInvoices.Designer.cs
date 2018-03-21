namespace Final
{
    partial class PrintInvoices
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
            System.Windows.Forms.Label labor_CostsLabel;
            System.Windows.Forms.Label parts_UsedLabel;
            System.Windows.Forms.Label totalLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taxLbl = new System.Windows.Forms.Label();
            this.outputIDLbl = new System.Windows.Forms.Label();
            this.outputLaborLbl = new System.Windows.Forms.Label();
            this.outputPartsLbl = new System.Windows.Forms.Label();
            this.outputTaxLbl = new System.Windows.Forms.Label();
            this.outputTotalLbl = new System.Windows.Forms.Label();
            this.printBttn = new System.Windows.Forms.Button();
            this.backBttn = new System.Windows.Forms.Button();
            invoice_IDLabel = new System.Windows.Forms.Label();
            labor_CostsLabel = new System.Windows.Forms.Label();
            parts_UsedLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_IDLabel
            // 
            invoice_IDLabel.AutoSize = true;
            invoice_IDLabel.Location = new System.Drawing.Point(91, 147);
            invoice_IDLabel.Name = "invoice_IDLabel";
            invoice_IDLabel.Size = new System.Drawing.Size(59, 13);
            invoice_IDLabel.TabIndex = 39;
            invoice_IDLabel.Text = "Invoice ID:";
            // 
            // labor_CostsLabel
            // 
            labor_CostsLabel.AutoSize = true;
            labor_CostsLabel.Location = new System.Drawing.Point(91, 173);
            labor_CostsLabel.Name = "labor_CostsLabel";
            labor_CostsLabel.Size = new System.Drawing.Size(66, 13);
            labor_CostsLabel.TabIndex = 40;
            labor_CostsLabel.Text = "Labor Costs:";
            // 
            // parts_UsedLabel
            // 
            parts_UsedLabel.AutoSize = true;
            parts_UsedLabel.Location = new System.Drawing.Point(91, 199);
            parts_UsedLabel.Name = "parts_UsedLabel";
            parts_UsedLabel.Size = new System.Drawing.Size(62, 13);
            parts_UsedLabel.TabIndex = 41;
            parts_UsedLabel.Text = "Parts Used:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(91, 254);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 42;
            totalLabel.Text = "Total:";
            totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Final.Properties.Resources._64113100_scaled_263x156_1;
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(91, 226);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(28, 13);
            this.taxLbl.TabIndex = 43;
            this.taxLbl.Text = "Tax:";
            // 
            // outputIDLbl
            // 
            this.outputIDLbl.AutoSize = true;
            this.outputIDLbl.Location = new System.Drawing.Point(247, 147);
            this.outputIDLbl.Name = "outputIDLbl";
            this.outputIDLbl.Size = new System.Drawing.Size(0, 13);
            this.outputIDLbl.TabIndex = 44;
            // 
            // outputLaborLbl
            // 
            this.outputLaborLbl.AutoSize = true;
            this.outputLaborLbl.Location = new System.Drawing.Point(247, 173);
            this.outputLaborLbl.Name = "outputLaborLbl";
            this.outputLaborLbl.Size = new System.Drawing.Size(0, 13);
            this.outputLaborLbl.TabIndex = 45;
            // 
            // outputPartsLbl
            // 
            this.outputPartsLbl.AutoSize = true;
            this.outputPartsLbl.Location = new System.Drawing.Point(247, 199);
            this.outputPartsLbl.Name = "outputPartsLbl";
            this.outputPartsLbl.Size = new System.Drawing.Size(0, 13);
            this.outputPartsLbl.TabIndex = 46;
            // 
            // outputTaxLbl
            // 
            this.outputTaxLbl.AutoSize = true;
            this.outputTaxLbl.Location = new System.Drawing.Point(247, 226);
            this.outputTaxLbl.Name = "outputTaxLbl";
            this.outputTaxLbl.Size = new System.Drawing.Size(0, 13);
            this.outputTaxLbl.TabIndex = 47;
            // 
            // outputTotalLbl
            // 
            this.outputTotalLbl.AutoSize = true;
            this.outputTotalLbl.Location = new System.Drawing.Point(247, 254);
            this.outputTotalLbl.Name = "outputTotalLbl";
            this.outputTotalLbl.Size = new System.Drawing.Size(0, 13);
            this.outputTotalLbl.TabIndex = 48;
            // 
            // printBttn
            // 
            this.printBttn.Location = new System.Drawing.Point(94, 350);
            this.printBttn.Name = "printBttn";
            this.printBttn.Size = new System.Drawing.Size(75, 23);
            this.printBttn.TabIndex = 49;
            this.printBttn.Text = "Print";
            this.printBttn.UseVisualStyleBackColor = true;
            this.printBttn.Click += new System.EventHandler(this.printBttn_Click);
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(207, 350);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 50;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            this.backBttn.Click += new System.EventHandler(this.backBttn_Click);
            // 
            // PrintInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 385);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.printBttn);
            this.Controls.Add(this.outputTotalLbl);
            this.Controls.Add(this.outputTaxLbl);
            this.Controls.Add(this.outputPartsLbl);
            this.Controls.Add(this.outputLaborLbl);
            this.Controls.Add(this.outputIDLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(invoice_IDLabel);
            this.Controls.Add(labor_CostsLabel);
            this.Controls.Add(parts_UsedLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PrintInvoices";
            this.Text = "PrintInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label outputIDLbl;
        private System.Windows.Forms.Label outputLaborLbl;
        private System.Windows.Forms.Label outputPartsLbl;
        private System.Windows.Forms.Label outputTaxLbl;
        private System.Windows.Forms.Label outputTotalLbl;
        private System.Windows.Forms.Button printBttn;
        private System.Windows.Forms.Button backBttn;
    }
}