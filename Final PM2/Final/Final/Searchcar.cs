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
    public partial class SearchCar : Form
    {
        public SearchCar()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataBaseDataSet);

        }

        private void Searchcar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataBaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.joesAutomotiveDataBaseDataSet.Vehicle);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //this.vehicleTableAdapter.SearchCarModel(searchCarTextBox.Text);
            //create car info form
            CarInfo carInfoForm = new CarInfo();
            carInfoForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            //create car info form
            CarInfo carInfoForm = new CarInfo();
            carInfoForm.ShowDialog();
        }
    }
}
