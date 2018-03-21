namespace Final
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
            System.Windows.Forms.Label invoice_IDLabel;
            System.Windows.Forms.Label labor_CostsLabel;
            System.Windows.Forms.Label parts_UsedLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceInfo));
            this.listBox = new System.Windows.Forms.ListBox();
            this.joesAutomotiveDataBaseDataSet = new Final.JoesAutomotiveDataBaseDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager();
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoice_IDTextBox = new System.Windows.Forms.TextBox();
            this.labor_CostsTextBox = new System.Windows.Forms.TextBox();
            this.parts_UsedTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.fluidCheckBox = new System.Windows.Forms.CheckBox();
            this.printBttn = new System.Windows.Forms.Button();
            invoice_IDLabel = new System.Windows.Forms.Label();
            labor_CostsLabel = new System.Windows.Forms.Label();
            parts_UsedLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoice_IDLabel
            // 
            invoice_IDLabel.AutoSize = true;
            invoice_IDLabel.Location = new System.Drawing.Point(189, 64);
            invoice_IDLabel.Name = "invoice_IDLabel";
            invoice_IDLabel.Size = new System.Drawing.Size(59, 13);
            invoice_IDLabel.TabIndex = 32;
            invoice_IDLabel.Text = "Invoice ID:";
            // 
            // labor_CostsLabel
            // 
            labor_CostsLabel.AutoSize = true;
            labor_CostsLabel.Location = new System.Drawing.Point(189, 90);
            labor_CostsLabel.Name = "labor_CostsLabel";
            labor_CostsLabel.Size = new System.Drawing.Size(66, 13);
            labor_CostsLabel.TabIndex = 34;
            labor_CostsLabel.Text = "Labor Costs:";
            // 
            // parts_UsedLabel
            // 
            parts_UsedLabel.AutoSize = true;
            parts_UsedLabel.Location = new System.Drawing.Point(189, 116);
            parts_UsedLabel.Name = "parts_UsedLabel";
            parts_UsedLabel.Size = new System.Drawing.Size(62, 13);
            parts_UsedLabel.TabIndex = 36;
            parts_UsedLabel.Text = "Parts Used:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(189, 142);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 38;
            totalLabel.Text = "Total:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 42);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(151, 134);
            this.listBox.TabIndex = 12;
            // 
            // joesAutomotiveDataBaseDataSet
            // 
            this.joesAutomotiveDataBaseDataSet.DataSetName = "JoesAutomotiveDataBaseDataSet";
            this.joesAutomotiveDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.joesAutomotiveDataBaseDataSet;
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
            this.tableAdapterManager.UpdateOrder = Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
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
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.invoicesBindingNavigator.TabIndex = 32;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
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
            // invoicesBindingNavigatorSaveItem
            // 
            this.invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesBindingNavigatorSaveItem.Image")));
            this.invoicesBindingNavigatorSaveItem.Name = "invoicesBindingNavigatorSaveItem";
            this.invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesBindingNavigatorSaveItem_Click);
            // 
            // invoice_IDTextBox
            // 
            this.invoice_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Invoice ID", true));
            this.invoice_IDTextBox.Location = new System.Drawing.Point(261, 61);
            this.invoice_IDTextBox.Name = "invoice_IDTextBox";
            this.invoice_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoice_IDTextBox.TabIndex = 33;
            // 
            // labor_CostsTextBox
            // 
            this.labor_CostsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Labor Costs", true));
            this.labor_CostsTextBox.Location = new System.Drawing.Point(261, 87);
            this.labor_CostsTextBox.Name = "labor_CostsTextBox";
            this.labor_CostsTextBox.Size = new System.Drawing.Size(100, 20);
            this.labor_CostsTextBox.TabIndex = 35;
            // 
            // parts_UsedTextBox
            // 
            this.parts_UsedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Parts Used", true));
            this.parts_UsedTextBox.Location = new System.Drawing.Point(261, 113);
            this.parts_UsedTextBox.Name = "parts_UsedTextBox";
            this.parts_UsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_UsedTextBox.TabIndex = 37;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(261, 139);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 39;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(286, 203);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // fluidCheckBox
            // 
            this.fluidCheckBox.AutoSize = true;
            this.fluidCheckBox.Location = new System.Drawing.Point(379, 60);
            this.fluidCheckBox.Name = "fluidCheckBox";
            this.fluidCheckBox.Size = new System.Drawing.Size(124, 17);
            this.fluidCheckBox.TabIndex = 41;
            this.fluidCheckBox.Text = "Fluid Check ($24.99)";
            this.fluidCheckBox.UseVisualStyleBackColor = true;
            // 
            // printBttn
            // 
            this.printBttn.Location = new System.Drawing.Point(176, 203);
            this.printBttn.Name = "printBttn";
            this.printBttn.Size = new System.Drawing.Size(75, 23);
            this.printBttn.TabIndex = 42;
            this.printBttn.Text = "Print Layout";
            this.printBttn.UseVisualStyleBackColor = true;
            this.printBttn.Click += new System.EventHandler(this.printBttn_Click);
            // 
            // InvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 238);
            this.Controls.Add(this.printBttn);
            this.Controls.Add(this.fluidCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(invoice_IDLabel);
            this.Controls.Add(this.invoice_IDTextBox);
            this.Controls.Add(labor_CostsLabel);
            this.Controls.Add(this.labor_CostsTextBox);
            this.Controls.Add(parts_UsedLabel);
            this.Controls.Add(this.parts_UsedTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Controls.Add(this.listBox);
            this.Name = "InvoiceInfo";
            this.Text = "InvoiceInfo";
            this.Load += new System.EventHandler(this.InvoiceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private JoesAutomotiveDataBaseDataSet joesAutomotiveDataBaseDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private JoesAutomotiveDataBaseDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox labor_CostsTextBox;
        private System.Windows.Forms.TextBox parts_UsedTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox fluidCheckBox;
        private System.Windows.Forms.Button printBttn;
    }
}