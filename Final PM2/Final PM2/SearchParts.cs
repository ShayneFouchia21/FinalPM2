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
    public partial class SearchParts : Form
    {
        public SearchParts()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Joes_AutomotivesDataSet2);

        }

        private void SearchParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Joes_AutomotiveInvoice.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter1.Fill(this._Joes_AutomotiveInvoice.Parts);
            // TODO: This line of code loads data into the '_Joes_AutomotivesDataSet2.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this._Joes_AutomotivesDataSet2.Parts);

        }
    }
}
