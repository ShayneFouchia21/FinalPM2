namespace Final
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
            this.customerButton = new System.Windows.Forms.Button();
            this.CarsButton = new System.Windows.Forms.Button();
            this.PartsButton = new System.Windows.Forms.Button();
            this.InvoicesButton = new System.Windows.Forms.Button();
            this.JAMLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(89, 85);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(120, 59);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // CarsButton
            // 
            this.CarsButton.Location = new System.Drawing.Point(307, 85);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(120, 59);
            this.CarsButton.TabIndex = 1;
            this.CarsButton.Text = "Car";
            this.CarsButton.UseVisualStyleBackColor = true;
            // 
            // PartsButton
            // 
            this.PartsButton.Location = new System.Drawing.Point(89, 183);
            this.PartsButton.Name = "PartsButton";
            this.PartsButton.Size = new System.Drawing.Size(120, 59);
            this.PartsButton.TabIndex = 2;
            this.PartsButton.Text = "Parts";
            this.PartsButton.UseVisualStyleBackColor = true;
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Location = new System.Drawing.Point(307, 183);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(120, 59);
            this.InvoicesButton.TabIndex = 3;
            this.InvoicesButton.Text = "Invoices";
            this.InvoicesButton.UseVisualStyleBackColor = true;
            // 
            // JAMLabel
            // 
            this.JAMLabel.AutoSize = true;
            this.JAMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JAMLabel.Location = new System.Drawing.Point(147, 51);
            this.JAMLabel.Name = "JAMLabel";
            this.JAMLabel.Size = new System.Drawing.Size(233, 31);
            this.JAMLabel.TabIndex = 4;
            this.JAMLabel.Text = "Joe\'s automotive";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(526, 311);
            this.Controls.Add(this.JAMLabel);
            this.Controls.Add(this.InvoicesButton);
            this.Controls.Add(this.PartsButton);
            this.Controls.Add(this.CarsButton);
            this.Controls.Add(this.customerButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.Button PartsButton;
        private System.Windows.Forms.Button InvoicesButton;
        private System.Windows.Forms.Label JAMLabel;
    }
}

