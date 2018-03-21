namespace Final
{
    partial class CustomerInfo
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
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label alternate_Phone_NumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label vehicleLabel;
            System.Windows.Forms.Label invoicesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfo));
            this.backButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.joesAutomotiveDataBaseDataSet = new Final.JoesAutomotiveDataBaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.alternate_Phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.invoicesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.notesTxtBx = new System.Windows.Forms.RichTextBox();
            customer_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            alternate_Phone_NumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            vehicleLabel = new System.Windows.Forms.Label();
            invoicesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(179, 32);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 13;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(179, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(179, 84);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(179, 110);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 19;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // alternate_Phone_NumberLabel
            // 
            alternate_Phone_NumberLabel.AutoSize = true;
            alternate_Phone_NumberLabel.Location = new System.Drawing.Point(179, 136);
            alternate_Phone_NumberLabel.Name = "alternate_Phone_NumberLabel";
            alternate_Phone_NumberLabel.Size = new System.Drawing.Size(126, 13);
            alternate_Phone_NumberLabel.TabIndex = 21;
            alternate_Phone_NumberLabel.Text = "Alternate Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(179, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Location = new System.Drawing.Point(179, 188);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new System.Drawing.Size(45, 13);
            vehicleLabel.TabIndex = 25;
            vehicleLabel.Text = "Vehicle:";
            // 
            // invoicesLabel
            // 
            invoicesLabel.AutoSize = true;
            invoicesLabel.Location = new System.Drawing.Point(179, 214);
            invoicesLabel.Name = "invoicesLabel";
            invoicesLabel.Size = new System.Drawing.Size(50, 13);
            invoicesLabel.TabIndex = 27;
            invoicesLabel.Text = "Invoices:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(243, 248);
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
            this.listBox.Location = new System.Drawing.Point(22, 48);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(151, 134);
            this.listBox.TabIndex = 12;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // joesAutomotiveDataBaseDataSet
            // 
            this.joesAutomotiveDataBaseDataSet.DataSetName = "JoesAutomotiveDataBaseDataSet";
            this.joesAutomotiveDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.joesAutomotiveDataBaseDataSet;
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
            this.tableAdapterManager.UpdateOrder = Final.JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.customerBindingNavigator.TabIndex = 13;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Customer ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(311, 29);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_IDTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(311, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(311, 81);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 18;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(311, 107);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_NumberTextBox.TabIndex = 20;
            // 
            // alternate_Phone_NumberTextBox
            // 
            this.alternate_Phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Alternate Phone Number", true));
            this.alternate_Phone_NumberTextBox.Location = new System.Drawing.Point(311, 133);
            this.alternate_Phone_NumberTextBox.Name = "alternate_Phone_NumberTextBox";
            this.alternate_Phone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.alternate_Phone_NumberTextBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(311, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Vehicle", true));
            this.vehicleTextBox.Location = new System.Drawing.Point(311, 185);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleTextBox.TabIndex = 26;
            // 
            // invoicesTextBox
            // 
            this.invoicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Invoices", true));
            this.invoicesTextBox.Location = new System.Drawing.Point(311, 211);
            this.invoicesTextBox.Name = "invoicesTextBox";
            this.invoicesTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoicesTextBox.TabIndex = 28;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(417, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(138, 134);
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            // 
            // notesTxtBx
            // 
            this.notesTxtBx.Location = new System.Drawing.Point(417, 152);
            this.notesTxtBx.Name = "notesTxtBx";
            this.notesTxtBx.Size = new System.Drawing.Size(136, 124);
            this.notesTxtBx.TabIndex = 32;
            this.notesTxtBx.Text = "";
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 283);
            this.Controls.Add(this.notesTxtBx);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberTextBox);
            this.Controls.Add(alternate_Phone_NumberLabel);
            this.Controls.Add(this.alternate_Phone_NumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(vehicleLabel);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(invoicesLabel);
            this.Controls.Add(this.invoicesTextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.backButton);
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listBox;
        private JoesAutomotiveDataBaseDataSet joesAutomotiveDataBaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private JoesAutomotiveDataBaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private JoesAutomotiveDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox alternate_Phone_NumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox invoicesTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox notesTxtBx;
    }
}