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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchParts));
            this.backBttn = new System.Windows.Forms.Button();
            this._Joes_AutomotivesDataSet2 = new Final_PM2._Joes_AutomotivesDataSet2();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager();
            this.partsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.partsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partsSearchTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBttn = new System.Windows.Forms.Button();
            this.showInfo = new System.Windows.Forms.Button();
            this._Joes_AutomotiveInvoice = new Final_PM2._Joes_AutomotiveInvoice();
            this.partsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter1 = new Final_PM2._Joes_AutomotiveInvoiceTableAdapters.PartsTableAdapter();
            this.tableAdapterManager1 = new Final_PM2._Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).BeginInit();
            this.partsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotiveInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(336, 284);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 3;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // _Joes_AutomotivesDataSet2
            // 
            this._Joes_AutomotivesDataSet2.DataSetName = "_Joes_AutomotivesDataSet2";
            this._Joes_AutomotivesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this._Joes_AutomotivesDataSet2;
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
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_PM2._Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // partsBindingNavigator
            // 
            this.partsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partsBindingNavigator.BindingSource = this.partsBindingSource;
            this.partsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.partsBindingNavigatorSaveItem});
            this.partsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partsBindingNavigator.Name = "partsBindingNavigator";
            this.partsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partsBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.partsBindingNavigator.TabIndex = 4;
            this.partsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // partsBindingNavigatorSaveItem
            // 
            this.partsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partsBindingNavigatorSaveItem.Image")));
            this.partsBindingNavigatorSaveItem.Name = "partsBindingNavigatorSaveItem";
            this.partsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partsBindingNavigatorSaveItem.Text = "Save Data";
            this.partsBindingNavigatorSaveItem.Click += new System.EventHandler(this.partsBindingNavigatorSaveItem_Click);
            // 
            // partsSearchTextbox
            // 
            this.partsSearchTextbox.Location = new System.Drawing.Point(242, 258);
            this.partsSearchTextbox.Name = "partsSearchTextbox";
            this.partsSearchTextbox.Size = new System.Drawing.Size(169, 20);
            this.partsSearchTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search For A Part:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBttn
            // 
            this.searchBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBttn.Location = new System.Drawing.Point(255, 284);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(75, 23);
            this.searchBttn.TabIndex = 7;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = true;
            // 
            // showInfo
            // 
            this.showInfo.Location = new System.Drawing.Point(295, 313);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(79, 45);
            this.showInfo.TabIndex = 8;
            this.showInfo.Text = "Show Info On Part";
            this.showInfo.UseVisualStyleBackColor = true;
            // 
            // _Joes_AutomotiveInvoice
            // 
            this._Joes_AutomotiveInvoice.DataSetName = "_Joes_AutomotiveInvoice";
            this._Joes_AutomotiveInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource1
            // 
            this.partsBindingSource1.DataMember = "Parts";
            this.partsBindingSource1.DataSource = this._Joes_AutomotiveInvoice;
            // 
            // partsTableAdapter1
            // 
            this.partsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.InvoicesTableAdapter = null;
            this.tableAdapterManager1.PartsTableAdapter = this.partsTableAdapter1;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Final_PM2._Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehicleTableAdapter = null;
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
            this.partsDataGridView.DataSource = this.partsBindingSource1;
            this.partsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.Size = new System.Drawing.Size(644, 220);
            this.partsDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stock Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock Number";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Compatible Vehicles For Part";
            this.dataGridViewTextBoxColumn6.HeaderText = "Compatible Vehicles For Part";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // SearchParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 392);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.showInfo);
            this.Controls.Add(this.searchBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partsSearchTextbox);
            this.Controls.Add(this.partsBindingNavigator);
            this.Controls.Add(this.backBttn);
            this.Name = "SearchParts";
            this.Text = "SearchParts";
            this.Load += new System.EventHandler(this.SearchParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).EndInit();
            this.partsBindingNavigator.ResumeLayout(false);
            this.partsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotiveInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBttn;
        private _Joes_AutomotivesDataSet2 _Joes_AutomotivesDataSet2;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private _Joes_AutomotivesDataSet2TableAdapters.PartsTableAdapter partsTableAdapter;
        private _Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton partsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partsSearchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.Button showInfo;
        private _Joes_AutomotiveInvoice _Joes_AutomotiveInvoice;
        private System.Windows.Forms.BindingSource partsBindingSource1;
        private _Joes_AutomotiveInvoiceTableAdapters.PartsTableAdapter partsTableAdapter1;
        private _Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}