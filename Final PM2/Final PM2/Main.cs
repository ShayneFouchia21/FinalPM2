using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_PM2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerBttn_Click(object sender, EventArgs e)
        {
            SearchCustomer mySearcedCustomer = new SearchCustomer();

            mySearcedCustomer.ShowDialog();
        }

        private void invoiceBttn_Click(object sender, EventArgs e)
        {
            
        }

        private void partsBttn_Click(object sender, EventArgs e)
        {
            SearchParts mySearchedPart = new SearchParts();

            mySearchedPart.ShowDialog();
        }

        private void vehicleBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
