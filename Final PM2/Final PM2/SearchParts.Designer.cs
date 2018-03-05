namespace Final_PM2
{
    partial class SearchParts
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
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsTxtBx = new System.Windows.Forms.TextBox();
            this.addPartBttn = new System.Windows.Forms.Button();
            this.backBttn = new System.Windows.Forms.Button();
            this.partsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partsTxtBx);
            this.partsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(29, 73);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.partsGroupBox.TabIndex = 0;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Search For Parts";
            // 
            // partsTxtBx
            // 
            this.partsTxtBx.Location = new System.Drawing.Point(23, 35);
            this.partsTxtBx.Name = "partsTxtBx";
            this.partsTxtBx.Size = new System.Drawing.Size(144, 26);
            this.partsTxtBx.TabIndex = 0;
            // 
            // addPartBttn
            // 
            this.addPartBttn.Location = new System.Drawing.Point(87, 179);
            this.addPartBttn.Name = "addPartBttn";
            this.addPartBttn.Size = new System.Drawing.Size(81, 37);
            this.addPartBttn.TabIndex = 1;
            this.addPartBttn.Text = "Add Part";
            this.addPartBttn.UseVisualStyleBackColor = true;
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(197, 226);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 3;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // SearchParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.addPartBttn);
            this.Controls.Add(this.partsGroupBox);
            this.Name = "SearchParts";
            this.Text = "SearchParts";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.TextBox partsTxtBx;
        private System.Windows.Forms.Button addPartBttn;
        private System.Windows.Forms.Button backBttn;
    }
}