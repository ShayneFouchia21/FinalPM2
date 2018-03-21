namespace Final
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
            this.components = new System.ComponentModel.Container();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.joesAutomotiveDataBaseDataSet = new Final.JoesAutomotiveDataBaseDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Location = new System.Drawing.Point(259, 12);
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchPartsTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(231, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(273, 293);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // joesAutomotiveDataBaseDataSet
            // 
            this.joesAutomotiveDataBaseDataSet.DataSetName = "JoesAutomotiveDataBaseDataSet";
            this.joesAutomotiveDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.joesAutomotiveDataBaseDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = this.partsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AutoGenerateColumns = false;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.partsDataGridView.DataSource = this.partsBindingSource;
            this.partsDataGridView.Location = new System.Drawing.Point(5, 67);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.Size = new System.Drawing.Size(646, 220);
            this.partsDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Parts ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Parts ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Parts In Stock";
            this.dataGridViewTextBoxColumn2.HeaderText = "Parts In Stock";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Parts On Order";
            this.dataGridViewTextBoxColumn3.HeaderText = "Parts On Order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Part Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Part Cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Part Cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Compatible Vehicles";
            this.dataGridViewTextBoxColumn6.HeaderText = "Compatible Vehicles";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(312, 38);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 11;
            this.addBttn.Text = "Add/Create";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // SearchParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 413);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPartsTextBox);
            this.Name = "SearchParts";
            this.Text = "SearchParts";
            this.Load += new System.EventHandler(this.SearchParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private JoesAutomotiveDataBaseDataSet joesAutomotiveDataBaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private JoesAutomotiveDataBaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button addBttn;
    }
}