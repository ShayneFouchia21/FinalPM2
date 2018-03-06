namespace Final_PM2
{
    partial class CarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfo));
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label date_RecievedLabel;
            System.Windows.Forms.Label date_ReturnedLabel;
            System.Windows.Forms.Label ownerLabel;
            this._Joes_AutomotivesDataSet1 = new Final_PM2._Joes_AutomotivesDataSet1();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Final_PM2._Joes_AutomotivesDataSet1TableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new Final_PM2._Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager();
            this.vehicleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vehicleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._Joes_AutomotivesDataSet2 = new Final_PM2._Joes_AutomotivesDataSet2();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter1 = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.VehicleTableAdapter();
            this.tableAdapterManager1 = new Final_PM2._Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.date_RecievedTextBox = new System.Windows.Forms.TextBox();
            this.date_ReturnedTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.backBttn = new System.Windows.Forms.Button();
            vINLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            date_RecievedLabel = new System.Windows.Forms.Label();
            date_ReturnedLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).BeginInit();
            this.vehicleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _Joes_AutomotivesDataSet1
            // 
            this._Joes_AutomotivesDataSet1.DataSetName = "_Joes_AutomotivesDataSet1";
            this._Joes_AutomotivesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this._Joes_AutomotivesDataSet1;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_PM2._Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicleBindingNavigator
            // 
            this.vehicleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehicleBindingNavigator.BindingSource = this.vehicleBindingSource;
            this.vehicleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehicleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehicleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vehicleBindingNavigatorSaveItem});
            this.vehicleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehicleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehicleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehicleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehicleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehicleBindingNavigator.Name = "vehicleBindingNavigator";
            this.vehicleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehicleBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.vehicleBindingNavigator.TabIndex = 0;
            this.vehicleBindingNavigator.Text = "bindingNavigator1";
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
            // vehicleBindingNavigatorSaveItem
            // 
            this.vehicleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehicleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleBindingNavigatorSaveItem.Image")));
            this.vehicleBindingNavigatorSaveItem.Name = "vehicleBindingNavigatorSaveItem";
            this.vehicleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vehicleBindingNavigatorSaveItem.Text = "Save Data";
            this.vehicleBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehicleBindingNavigatorSaveItem_Click);
            // 
            // _Joes_AutomotivesDataSet2
            // 
            this._Joes_AutomotivesDataSet2.DataSetName = "_Joes_AutomotivesDataSet2";
            this._Joes_AutomotivesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataMember = "Vehicle";
            this.vehicleBindingSource1.DataSource = this._Joes_AutomotivesDataSet2;
            // 
            // vehicleTableAdapter1
            // 
            this.vehicleTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.InvoicesTableAdapter = null;
            this.tableAdapterManager1.PartsTableAdapter = null;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Final_PM2._Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehicleTableAdapter = this.vehicleTableAdapter1;
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(105, 77);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(28, 13);
            vINLabel.TabIndex = 1;
            vINLabel.Text = "VIN:";
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(193, 74);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(100, 20);
            this.vINTextBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(105, 103);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(193, 100);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(105, 129);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 5;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(193, 126);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(105, 155);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(193, 152);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(105, 181);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 9;
            mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(193, 178);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 10;
            // 
            // date_RecievedLabel
            // 
            date_RecievedLabel.AutoSize = true;
            date_RecievedLabel.Location = new System.Drawing.Point(105, 207);
            date_RecievedLabel.Name = "date_RecievedLabel";
            date_RecievedLabel.Size = new System.Drawing.Size(82, 13);
            date_RecievedLabel.TabIndex = 11;
            date_RecievedLabel.Text = "Date Recieved:";
            // 
            // date_RecievedTextBox
            // 
            this.date_RecievedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Date Recieved", true));
            this.date_RecievedTextBox.Location = new System.Drawing.Point(193, 204);
            this.date_RecievedTextBox.Name = "date_RecievedTextBox";
            this.date_RecievedTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_RecievedTextBox.TabIndex = 12;
            // 
            // date_ReturnedLabel
            // 
            date_ReturnedLabel.AutoSize = true;
            date_ReturnedLabel.Location = new System.Drawing.Point(105, 233);
            date_ReturnedLabel.Name = "date_ReturnedLabel";
            date_ReturnedLabel.Size = new System.Drawing.Size(80, 13);
            date_ReturnedLabel.TabIndex = 13;
            date_ReturnedLabel.Text = "Date Returned:";
            // 
            // date_ReturnedTextBox
            // 
            this.date_ReturnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Date Returned", true));
            this.date_ReturnedTextBox.Location = new System.Drawing.Point(193, 230);
            this.date_ReturnedTextBox.Name = "date_ReturnedTextBox";
            this.date_ReturnedTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_ReturnedTextBox.TabIndex = 14;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(105, 259);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(41, 13);
            ownerLabel.TabIndex = 15;
            ownerLabel.Text = "Owner:";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource1, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(193, 256);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerTextBox.TabIndex = 16;
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(207, 282);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 17;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // CarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 377);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(date_RecievedLabel);
            this.Controls.Add(this.date_RecievedTextBox);
            this.Controls.Add(date_ReturnedLabel);
            this.Controls.Add(this.date_ReturnedTextBox);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.vehicleBindingNavigator);
            this.Name = "CarInfo";
            this.Text = "CarInfo";
            this.Load += new System.EventHandler(this.CarInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).EndInit();
            this.vehicleBindingNavigator.ResumeLayout(false);
            this.vehicleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotivesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Joes_AutomotivesDataSet1 _Joes_AutomotivesDataSet1;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private _Joes_AutomotivesDataSet1TableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private _Joes_AutomotivesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehicleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vehicleBindingNavigatorSaveItem;
        private _Joes_AutomotivesDataSet2 _Joes_AutomotivesDataSet2;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
        private _Joes_AutomotivesDataSet2TableAdapters.VehicleTableAdapter vehicleTableAdapter1;
        private _Joes_AutomotivesDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox date_RecievedTextBox;
        private System.Windows.Forms.TextBox date_ReturnedTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Button backBttn;
    }
}