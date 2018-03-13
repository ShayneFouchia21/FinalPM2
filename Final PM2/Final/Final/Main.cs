using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            SearchCustomer customerForm = new SearchCustomer();
            customerForm.ShowDialog();
            
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {
            SearchCar carForm = new SearchCar();
            carForm.ShowDialog();
        }

        private void PartsButton_Click(object sender, EventArgs e)
        {
            SearchParts partForm = new SearchParts();
            partForm.ShowDialog();
        }

        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            SearchInvoices invoiceForm = new SearchInvoices();
            invoiceForm.ShowDialog();
        }
    }
}
