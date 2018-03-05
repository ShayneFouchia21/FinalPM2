namespace Final_PM2
{
    partial class SearchCar
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
            this.vehicleTxtBx = new System.Windows.Forms.TextBox();
            this.vehicleGroupBx = new System.Windows.Forms.GroupBox();
            this.addCarBttn = new System.Windows.Forms.Button();
            this.vehicleGroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleTxtBx
            // 
            this.vehicleTxtBx.Location = new System.Drawing.Point(40, 40);
            this.vehicleTxtBx.Name = "vehicleTxtBx";
            this.vehicleTxtBx.Size = new System.Drawing.Size(100, 26);
            this.vehicleTxtBx.TabIndex = 0;
            // 
            // vehicleGroupBx
            // 
            this.vehicleGroupBx.Controls.Add(this.vehicleTxtBx);
            this.vehicleGroupBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleGroupBx.Location = new System.Drawing.Point(51, 40);
            this.vehicleGroupBx.Name = "vehicleGroupBx";
            this.vehicleGroupBx.Size = new System.Drawing.Size(200, 100);
            this.vehicleGroupBx.TabIndex = 1;
            this.vehicleGroupBx.TabStop = false;
            this.vehicleGroupBx.Text = "Search For Vehicle";
            // 
            // addCarBttn
            // 
            this.addCarBttn.Location = new System.Drawing.Point(82, 146);
            this.addCarBttn.Name = "addCarBttn";
            this.addCarBttn.Size = new System.Drawing.Size(120, 47);
            this.addCarBttn.TabIndex = 2;
            this.addCarBttn.Text = "Add New Car";
            this.addCarBttn.UseVisualStyleBackColor = true;
            // 
            // SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 249);
            this.Controls.Add(this.addCarBttn);
            this.Controls.Add(this.vehicleGroupBx);
            this.Name = "SearchCar";
            this.Text = "SearchCar";
            this.vehicleGroupBx.ResumeLayout(false);
            this.vehicleGroupBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox vehicleTxtBx;
        private System.Windows.Forms.GroupBox vehicleGroupBx;
        private System.Windows.Forms.Button addCarBttn;
    }
}