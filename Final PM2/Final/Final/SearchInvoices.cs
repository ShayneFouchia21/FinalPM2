﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class SearchInvoices : Form
    {
        public SearchInvoices()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataBaseDataSet);

        }

        private void SearchInvoicess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataBaseDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.joesAutomotiveDataBaseDataSet.Invoices);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // opens invoice info form
            InvoiceInfo invoiceinfoform = new InvoiceInfo();
            invoiceinfoform.ShowDialog();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            // opens invoice info form
            InvoiceInfo invoiceinfoform = new InvoiceInfo();
            invoiceinfoform.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // closes search info form
            this.Close();
        }
    }
}
