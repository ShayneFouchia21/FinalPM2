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
    public partial class PartsInfo : Form
    {
        public PartsInfo()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataBaseDataSet);

        }

        private void PartsInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataBaseDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.joesAutomotiveDataBaseDataSet.Parts);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //closes the current form.
            this.Close();
        }
    }
}
