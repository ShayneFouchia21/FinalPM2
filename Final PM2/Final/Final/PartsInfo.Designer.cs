namespace Final
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
            System.Windows.Forms.Label parts_IDLabel;
            System.Windows.Forms.Label parts_In_StockLabel;
            System.Windows.Forms.Label parts_On_OrderLabel;
            System.Windows.Forms.Label part_NameLabel;
            System.Windows.Forms.Label part_CostLabel;
            System.Windows.Forms.Label compatible_VehiclesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsInfo));
            this.backButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.joesAutomotiveDataBaseDataSet = new Final.JoesAutomotiveDataBaseDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager();
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
            this.parts_IDTextBox = new System.Windows.Forms.TextBox();
            this.parts_In_StockTextBox = new System.Windows.Forms.TextBox();
            this.parts_On_OrderTextBox = new System.Windows.Forms.TextBox();
            this.part_NameTextBox = new System.Windows.Forms.TextBox();
            this.part_CostTextBox = new System.Windows.Forms.TextBox();
            this.compatible_VehiclesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.notesTxtBx = new System.Windows.Forms.RichTextBox();
            parts_IDLabel = new System.Windows.Forms.Label();
            parts_In_StockLabel = new System.Windows.Forms.Label();
            parts_On_OrderLabel = new System.Windows.Forms.Label();
            part_NameLabel = new System.Windows.Forms.Label();
            part_CostLabel = new System.Windows.Forms.Label();
            compatible_VehiclesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).BeginInit();
            this.partsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parts_IDLabel
            // 
            parts_IDLabel.AutoSize = true;
            parts_IDLabel.Location = new System.Drawing.Point(191, 67);
            parts_IDLabel.Name = "parts_IDLabel";
            parts_IDLabel.Size = new System.Drawing.Size(48, 13);
            parts_IDLabel.TabIndex = 14;
            parts_IDLabel.Text = "Parts ID:";
            // 
            // parts_In_StockLabel
            // 
            parts_In_StockLabel.AutoSize = true;
            parts_In_StockLabel.Location = new System.Drawing.Point(191, 93);
            parts_In_StockLabel.Name = "parts_In_StockLabel";
            parts_In_StockLabel.Size = new System.Drawing.Size(77, 13);
            parts_In_StockLabel.TabIndex = 16;
            parts_In_StockLabel.Text = "Parts In Stock:";
            // 
            // parts_On_OrderLabel
            // 
            parts_On_OrderLabel.AutoSize = true;
            parts_On_OrderLabel.Location = new System.Drawing.Point(191, 119);
            parts_On_OrderLabel.Name = "parts_On_OrderLabel";
            parts_On_OrderLabel.Size = new System.Drawing.Size(80, 13);
            parts_On_OrderLabel.TabIndex = 18;
            parts_On_OrderLabel.Text = "Parts On Order:";
            // 
            // part_NameLabel
            // 
            part_NameLabel.AutoSize = true;
            part_NameLabel.Location = new System.Drawing.Point(191, 145);
            part_NameLabel.Name = "part_NameLabel";
            part_NameLabel.Size = new System.Drawing.Size(60, 13);
            part_NameLabel.TabIndex = 20;
            part_NameLabel.Text = "Part Name:";
            // 
            // part_CostLabel
            // 
            part_CostLabel.AutoSize = true;
            part_CostLabel.Location = new System.Drawing.Point(191, 171);
            part_CostLabel.Name = "part_CostLabel";
            part_CostLabel.Size = new System.Drawing.Size(53, 13);
            part_CostLabel.TabIndex = 22;
            part_CostLabel.Text = "Part Cost:";
            // 
            // compatible_VehiclesLabel
            // 
            compatible_VehiclesLabel.AutoSize = true;
            compatible_VehiclesLabel.Location = new System.Drawing.Point(191, 197);
            compatible_VehiclesLabel.Name = "compatible_VehiclesLabel";
            compatible_VehiclesLabel.Size = new System.Drawing.Size(105, 13);
            compatible_VehiclesLabel.TabIndex = 24;
            compatible_VehiclesLabel.Text = "Compatible Vehicles:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(254, 243);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 76);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(151, 134);
            this.listBox.TabIndex = 13;
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
            this.partsBindingNavigator.Size = new System.Drawing.Size(562, 25);
            this.partsBindingNavigator.TabIndex = 14;
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
            // parts_IDTextBox
            // 
            this.parts_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts ID", true));
            this.parts_IDTextBox.Location = new System.Drawing.Point(302, 64);
            this.parts_IDTextBox.Name = "parts_IDTextBox";
            this.parts_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_IDTextBox.TabIndex = 15;
            // 
            // parts_In_StockTextBox
            // 
            this.parts_In_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts In Stock", true));
            this.parts_In_StockTextBox.Location = new System.Drawing.Point(302, 90);
            this.parts_In_StockTextBox.Name = "parts_In_StockTextBox";
            this.parts_In_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_In_StockTextBox.TabIndex = 17;
            // 
            // parts_On_OrderTextBox
            // 
            this.parts_On_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts On Order", true));
            this.parts_On_OrderTextBox.Location = new System.Drawing.Point(302, 116);
            this.parts_On_OrderTextBox.Name = "parts_On_OrderTextBox";
            this.parts_On_OrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_On_OrderTextBox.TabIndex = 19;
            // 
            // part_NameTextBox
            // 
            this.part_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part Name", true));
            this.part_NameTextBox.Location = new System.Drawing.Point(302, 142);
            this.part_NameTextBox.Name = "part_NameTextBox";
            this.part_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_NameTextBox.TabIndex = 21;
            // 
            // part_CostTextBox
            // 
            this.part_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part Cost", true));
            this.part_CostTextBox.Location = new System.Drawing.Point(302, 168);
            this.part_CostTextBox.Name = "part_CostTextBox";
            this.part_CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_CostTextBox.TabIndex = 23;
            // 
            // compatible_VehiclesTextBox
            // 
            this.compatible_VehiclesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Compatible Vehicles", true));
            this.compatible_VehiclesTextBox.Location = new System.Drawing.Point(302, 194);
            this.compatible_VehiclesTextBox.Name = "compatible_VehiclesTextBox";
            this.compatible_VehiclesTextBox.Size = new System.Drawing.Size(100, 20);
            this.compatible_VehiclesTextBox.TabIndex = 25;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(408, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(138, 134);
            this.pictureBox.TabIndex = 26;
            this.pictureBox.TabStop = false;
            // 
            // notesTxtBx
            // 
            this.notesTxtBx.Location = new System.Drawing.Point(408, 152);
            this.notesTxtBx.Name = "notesTxtBx";
            this.notesTxtBx.Size = new System.Drawing.Size(136, 124);
            this.notesTxtBx.TabIndex = 32;
            this.notesTxtBx.Text = "";
            // 
            // PartsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 290);
            this.Controls.Add(this.notesTxtBx);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(parts_IDLabel);
            this.Controls.Add(this.parts_IDTextBox);
            this.Controls.Add(parts_In_StockLabel);
            this.Controls.Add(this.parts_In_StockTextBox);
            this.Controls.Add(parts_On_OrderLabel);
            this.Controls.Add(this.parts_On_OrderTextBox);
            this.Controls.Add(part_NameLabel);
            this.Controls.Add(this.part_NameTextBox);
            this.Controls.Add(part_CostLabel);
            this.Controls.Add(this.part_CostTextBox);
            this.Controls.Add(compatible_VehiclesLabel);
            this.Controls.Add(this.compatible_VehiclesTextBox);
            this.Controls.Add(this.partsBindingNavigator);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.backButton);
            this.Name = "PartsInfo";
            this.Text = "PartsInfo";
            this.Load += new System.EventHandler(this.PartsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).EndInit();
            this.partsBindingNavigator.ResumeLayout(false);
            this.partsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listBox;
        private JoesAutomotiveDataBaseDataSet joesAutomotiveDataBaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private JoesAutomotiveDataBaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox parts_IDTextBox;
        private System.Windows.Forms.TextBox parts_In_StockTextBox;
        private System.Windows.Forms.TextBox parts_On_OrderTextBox;
        private System.Windows.Forms.TextBox part_NameTextBox;
        private System.Windows.Forms.TextBox part_CostTextBox;
        private System.Windows.Forms.TextBox compatible_VehiclesTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox notesTxtBx;
    }
}