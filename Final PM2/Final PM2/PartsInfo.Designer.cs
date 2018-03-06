namespace Final_PM2
{
    partial class PartsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsInfo));
            System.Windows.Forms.Label stock_NumberLabel;
            System.Windows.Forms.Label parts_In_StockLabel;
            System.Windows.Forms.Label parts_On_OrderLabel;
            System.Windows.Forms.Label part_NameLabel;
            System.Windows.Forms.Label part_CostLabel;
            System.Windows.Forms.Label compatible_Vehicles_For_PartLabel;
            this._Joes_AutomotivesDataSet2 = new Final_PM2._Joes_AutomotivesDataSet2();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager();
            this.partsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.partsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stock_NumberTextBox = new System.Windows.Forms.TextBox();
            this.parts_In_StockTextBox = new System.Windows.Forms.TextBox();
            this.parts_On_OrderTextBox = new System.Windows.Forms.TextBox();
            this.part_NameTextBox = new System.Windows.Forms.TextBox();
            this.part_CostTextBox = new System.Windows.Forms.TextBox();
            this.compatible_Vehicles_For_PartTextBox = new System.Windows.Forms.TextBox();
            this.backBttn = new System.Windows.Forms.Button();
            stock_NumberLabel = new System.Windows.Forms.Label();
            parts_In_StockLabel = new System.Windows.Forms.Label();
            parts_On_OrderLabel = new System.Windows.Forms.Label();
            part_NameLabel = new System.Windows.Forms.Label();
            part_CostLabel = new System.Windows.Forms.Label();
            compatible_Vehicles_For_PartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).BeginInit();
            this.partsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.partsBindingNavigator.Size = new System.Drawing.Size(508, 25);
            this.partsBindingNavigator.TabIndex = 0;
            this.partsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // partsBindingNavigatorSaveItem
            // 
            this.partsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partsBindingNavigatorSaveItem.Image")));
            this.partsBindingNavigatorSaveItem.Name = "partsBindingNavigatorSaveItem";
            this.partsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.partsBindingNavigatorSaveItem.Text = "Save Data";
            this.partsBindingNavigatorSaveItem.Click += new System.EventHandler(this.partsBindingNavigatorSaveItem_Click);
            // 
            // stock_NumberLabel
            // 
            stock_NumberLabel.AutoSize = true;
            stock_NumberLabel.Location = new System.Drawing.Point(104, 93);
            stock_NumberLabel.Name = "stock_NumberLabel";
            stock_NumberLabel.Size = new System.Drawing.Size(78, 13);
            stock_NumberLabel.TabIndex = 1;
            stock_NumberLabel.Text = "Stock Number:";
            // 
            // stock_NumberTextBox
            // 
            this.stock_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Stock Number", true));
            this.stock_NumberTextBox.Location = new System.Drawing.Point(255, 90);
            this.stock_NumberTextBox.Name = "stock_NumberTextBox";
            this.stock_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.stock_NumberTextBox.TabIndex = 2;
            // 
            // parts_In_StockLabel
            // 
            parts_In_StockLabel.AutoSize = true;
            parts_In_StockLabel.Location = new System.Drawing.Point(104, 119);
            parts_In_StockLabel.Name = "parts_In_StockLabel";
            parts_In_StockLabel.Size = new System.Drawing.Size(77, 13);
            parts_In_StockLabel.TabIndex = 3;
            parts_In_StockLabel.Text = "Parts In Stock:";
            // 
            // parts_In_StockTextBox
            // 
            this.parts_In_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts In Stock", true));
            this.parts_In_StockTextBox.Location = new System.Drawing.Point(255, 116);
            this.parts_In_StockTextBox.Name = "parts_In_StockTextBox";
            this.parts_In_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_In_StockTextBox.TabIndex = 4;
            // 
            // parts_On_OrderLabel
            // 
            parts_On_OrderLabel.AutoSize = true;
            parts_On_OrderLabel.Location = new System.Drawing.Point(104, 145);
            parts_On_OrderLabel.Name = "parts_On_OrderLabel";
            parts_On_OrderLabel.Size = new System.Drawing.Size(80, 13);
            parts_On_OrderLabel.TabIndex = 5;
            parts_On_OrderLabel.Text = "Parts On Order:";
            // 
            // parts_On_OrderTextBox
            // 
            this.parts_On_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts On Order", true));
            this.parts_On_OrderTextBox.Location = new System.Drawing.Point(255, 142);
            this.parts_On_OrderTextBox.Name = "parts_On_OrderTextBox";
            this.parts_On_OrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_On_OrderTextBox.TabIndex = 6;
            // 
            // part_NameLabel
            // 
            part_NameLabel.AutoSize = true;
            part_NameLabel.Location = new System.Drawing.Point(104, 171);
            part_NameLabel.Name = "part_NameLabel";
            part_NameLabel.Size = new System.Drawing.Size(60, 13);
            part_NameLabel.TabIndex = 7;
            part_NameLabel.Text = "Part Name:";
            // 
            // part_NameTextBox
            // 
            this.part_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part Name", true));
            this.part_NameTextBox.Location = new System.Drawing.Point(255, 168);
            this.part_NameTextBox.Name = "part_NameTextBox";
            this.part_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_NameTextBox.TabIndex = 8;
            // 
            // part_CostLabel
            // 
            part_CostLabel.AutoSize = true;
            part_CostLabel.Location = new System.Drawing.Point(104, 197);
            part_CostLabel.Name = "part_CostLabel";
            part_CostLabel.Size = new System.Drawing.Size(53, 13);
            part_CostLabel.TabIndex = 9;
            part_CostLabel.Text = "Part Cost:";
            // 
            // part_CostTextBox
            // 
            this.part_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part Cost", true));
            this.part_CostTextBox.Location = new System.Drawing.Point(255, 194);
            this.part_CostTextBox.Name = "part_CostTextBox";
            this.part_CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_CostTextBox.TabIndex = 10;
            // 
            // compatible_Vehicles_For_PartLabel
            // 
            compatible_Vehicles_For_PartLabel.AutoSize = true;
            compatible_Vehicles_For_PartLabel.Location = new System.Drawing.Point(104, 223);
            compatible_Vehicles_For_PartLabel.Name = "compatible_Vehicles_For_PartLabel";
            compatible_Vehicles_For_PartLabel.Size = new System.Drawing.Size(145, 13);
            compatible_Vehicles_For_PartLabel.TabIndex = 11;
            compatible_Vehicles_For_PartLabel.Text = "Compatible Vehicles For Part:";
            // 
            // compatible_Vehicles_For_PartTextBox
            // 
            this.compatible_Vehicles_For_PartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Compatible Vehicles For Part", true));
            this.compatible_Vehicles_For_PartTextBox.Location = new System.Drawing.Point(255, 220);
            this.compatible_Vehicles_For_PartTextBox.Name = "compatible_Vehicles_For_PartTextBox";
            this.compatible_Vehicles_For_PartTextBox.Size = new System.Drawing.Size(100, 20);
            this.compatible_Vehicles_For_PartTextBox.TabIndex = 12;
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(280, 246);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 13;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // PartsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 346);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(stock_NumberLabel);
            this.Controls.Add(this.stock_NumberTextBox);
            this.Controls.Add(parts_In_StockLabel);
            this.Controls.Add(this.parts_In_StockTextBox);
            this.Controls.Add(parts_On_OrderLabel);
            this.Controls.Add(this.parts_On_OrderTextBox);
            this.Controls.Add(part_NameLabel);
            this.Controls.Add(this.part_NameTextBox);
            this.Controls.Add(part_CostLabel);
            this.Controls.Add(this.part_CostTextBox);
            this.Controls.Add(compatible_Vehicles_For_PartLabel);
            this.Controls.Add(this.compatible_Vehicles_For_PartTextBox);
            this.Controls.Add(this.partsBindingNavigator);
            this.Name = "PartsInfo";
            this.Text = "PartsInfo";
            this.Load += new System.EventHandler(this.PartsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).EndInit();
            this.partsBindingNavigator.ResumeLayout(false);
            this.partsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox stock_NumberTextBox;
        private System.Windows.Forms.TextBox parts_In_StockTextBox;
        private System.Windows.Forms.TextBox parts_On_OrderTextBox;
        private System.Windows.Forms.TextBox part_NameTextBox;
        private System.Windows.Forms.TextBox part_CostTextBox;
        private System.Windows.Forms.TextBox compatible_Vehicles_For_PartTextBox;
        private System.Windows.Forms.Button backBttn;
    }
}