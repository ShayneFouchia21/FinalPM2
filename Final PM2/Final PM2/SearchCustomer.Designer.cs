namespace Final_PM2
{
    partial class SearchCustomer
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
            this.components = new System.ComponentModel.Container();
            this.backBttn = new System.Windows.Forms.Button();
            this._Joes_AutomotivesDataSet1 = new Final_PM2._Joes_AutomotivesDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Final_PM2._Joes_AutomotivesDataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Final_PM2._Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager();
            this.customerGroup = new System.Windows.Forms.GroupBox();
            this.searchCustomerTxt = new System.Windows.Forms.TextBox();
            this.addNewCustBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.customerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(294, 220);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 3;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // _Joes_AutomotivesDataSet1
            // 
            this._Joes_AutomotivesDataSet1.DataSetName = "_Joes_AutomotivesDataSet1";
            this._Joes_AutomotivesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this._Joes_AutomotivesDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_PM2._Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // customerGroup
            // 
            this.customerGroup.Controls.Add(this.searchCustomerTxt);
            this.customerGroup.Location = new System.Drawing.Point(85, 60);
            this.customerGroup.Name = "customerGroup";
            this.customerGroup.Size = new System.Drawing.Size(200, 100);
            this.customerGroup.TabIndex = 4;
            this.customerGroup.TabStop = false;
            this.customerGroup.Text = "Search For Customer";
            // 
            // searchCustomerTxt
            // 
            this.searchCustomerTxt.Location = new System.Drawing.Point(48, 40);
            this.searchCustomerTxt.Name = "searchCustomerTxt";
            this.searchCustomerTxt.Size = new System.Drawing.Size(100, 20);
            this.searchCustomerTxt.TabIndex = 0;
            // 
            // addNewCustBttn
            // 
            this.addNewCustBttn.Location = new System.Drawing.Point(85, 220);
            this.addNewCustBttn.Name = "addNewCustBttn";
            this.addNewCustBttn.Size = new System.Drawing.Size(109, 23);
            this.addNewCustBttn.TabIndex = 5;
            this.addNewCustBttn.Text = "Add new customer";
            this.addNewCustBttn.UseVisualStyleBackColor = true;
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 331);
            this.Controls.Add(this.addNewCustBttn);
            this.Controls.Add(this.customerGroup);
            this.Controls.Add(this.backBttn);
            this.Name = "SearchCustomer";
            this.Text = "SearchCustomer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.customerGroup.ResumeLayout(false);
            this.customerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBttn;
        private _Joes_AutomotivesDataSet1 _Joes_AutomotivesDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private _Joes_AutomotivesDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private _Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox customerGroup;
        private System.Windows.Forms.TextBox searchCustomerTxt;
        private System.Windows.Forms.Button addNewCustBttn;
    }
}