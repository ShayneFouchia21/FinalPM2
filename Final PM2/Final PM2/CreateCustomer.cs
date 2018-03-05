﻿using System;
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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Joes_AutomotivesDataSet1);

        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Joes_AutomotivesDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this._Joes_AutomotivesDataSet1.Customer);

        }
    }
}
