namespace Final_PM2
{
    partial class InvoiceInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceInfo));
            System.Windows.Forms.Label invoice_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label total_PriceLabel;
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoice_IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.total_PriceTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Joes_AutomotiveInvoice = new Final_PM2._Joes_AutomotiveInvoice();
            this.invoicesTableAdapter = new Final_PM2._Joes_AutomotiveInvoiceTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new Final_PM2._Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager();
            this.backBttn = new System.Windows.Forms.Button();
            invoice_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            total_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotiveInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesBindingNavigator
            // 
            this.invoicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoicesBindingNavigator.BindingSource = this.invoicesBindingSource;
            this.invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoicesBindingNavigatorSaveItem});
            this.invoicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoicesBindingNavigator.Name = "invoicesBindingNavigator";
            this.invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(428, 25);
            this.invoicesBindingNavigator.TabIndex = 0;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // invoicesBindingNavigatorSaveItem
            // 
            this.invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesBindingNavigatorSaveItem.Image")));
            this.invoicesBindingNavigatorSaveItem.Name = "invoicesBindingNavigatorSaveItem";
            this.invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesBindingNavigatorSaveItem_Click);
            // 
            // invoice_IDLabel
            // 
            invoice_IDLabel.AutoSize = true;
            invoice_IDLabel.Location = new System.Drawing.Point(120, 107);
            invoice_IDLabel.Name = "invoice_IDLabel";
            invoice_IDLabel.Size = new System.Drawing.Size(59, 13);
            invoice_IDLabel.TabIndex = 1;
            invoice_IDLabel.Text = "Invoice ID:";
            // 
            // invoice_IDTextBox
            // 
            this.invoice_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Invoice ID", true));
            this.invoice_IDTextBox.Location = new System.Drawing.Point(187, 104);
            this.invoice_IDTextBox.Name = "invoice_IDTextBox";
            this.invoice_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoice_IDTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(120, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(187, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(120, 159);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(187, 156);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 6;
            // 
            // total_PriceLabel
            // 
            total_PriceLabel.AutoSize = true;
            total_PriceLabel.Location = new System.Drawing.Point(120, 185);
            total_PriceLabel.Name = "total_PriceLabel";
            total_PriceLabel.Size = new System.Drawing.Size(61, 13);
            total_PriceLabel.TabIndex = 7;
            total_PriceLabel.Text = "Total Price:";
            // 
            // total_PriceTextBox
            // 
            this.total_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Total Price", true));
            this.total_PriceTextBox.Location = new System.Drawing.Point(187, 182);
            this.total_PriceTextBox.Name = "total_PriceTextBox";
            this.total_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_PriceTextBox.TabIndex = 8;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this._Joes_AutomotiveInvoice;
            // 
            // _Joes_AutomotiveInvoice
            // 
            this._Joes_AutomotiveInvoice.DataSetName = "_Joes_AutomotiveInvoice";
            this._Joes_AutomotiveInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_PM2._Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(200, 208);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 9;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            // 
            // InvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 354);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(invoice_IDLabel);
            this.Controls.Add(this.invoice_IDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(total_PriceLabel);
            this.Controls.Add(this.total_PriceTextBox);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Name = "InvoiceInfo";
            this.Text = "InvoiceInfo";
            this.Load += new System.EventHandler(this.InvoiceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Joes_AutomotiveInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Joes_AutomotiveInvoice _Joes_AutomotiveInvoice;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private _Joes_AutomotiveInvoiceTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private _Joes_AutomotiveInvoiceTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoice_IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox total_PriceTextBox;
        private System.Windows.Forms.Button backBttn;
    }
}