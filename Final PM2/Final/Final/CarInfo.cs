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
    public partial class CarInfo : Form
    {
        public CarInfo()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataBaseDataSet);

        }

        private void CarInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataBaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.joesAutomotiveDataBaseDataSet.Vehicle);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
