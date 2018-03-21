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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }
        //create variables in order to check
        public string name, phone, altPhone, email;
        public bool nameValid, phoneValid, altPhoneValid, emailValid;

        

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //set all variables to start out false
            nameValid = false;
            phoneValid = false;
            altPhoneValid = false;
            emailValid = false;
            //make all variables set to the proper textboxes
            name = nameTextBox.Text;

            phone = phone_NumberTextBox.Text;

           altPhone = alternate_Phone_NumberTextBox.Text;

            email = emailTextBox.Text;

            //check name
            foreach (char ch in name)
            {
                if ((char.IsDigit(ch) || (char.IsPunctuation(ch))))
                {
                    nameValid = false;
                }
                else
                {
                    nameValid = true;
                }
            }
            //check phone number
            foreach (char ch1 in phone)
            {
                if ((char.IsDigit(ch1)))
                {
                    
                    phoneValid = true;
                }
                else
                {
                    if ((phone[0] == '(') && (phone[4] == ')') && (phone[8] == '-'))
                    {
                        phoneValid = true;
                    }
                    else
                    {
                        phoneValid = false;
                    }
                }
            }
            //check altphone
            foreach (char ch2 in altPhone)
            {
                if ((char.IsDigit(ch2)))
                {
                    altPhoneValid = true;
                }

                else
                {
                    if (altPhone[0] == '(' && (altPhone[4] == ')') && (altPhone[8] == '-'))
                    {
                        altPhoneValid = true;

                    }
                    else
                    {
                        altPhoneValid = false;
                    }
                }

                    
                
            }
            //check email
            foreach(char ch3 in email)
            {
                if (char.IsSymbol(ch3))
                {
                    emailValid = true;
                }
            }


            if (nameValid = true && (phoneValid = true) && (altPhoneValid = true) && (emailValid = true))
            {


               // this.Validate();
               // this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataBaseDataSet);
            }
            else
            {
                MessageBox.Show("Invalid information added, please fix the error and try again.");
                if (nameValid == false)
                {
                    MessageBox.Show("Please use all letters on names.");
                }

                if (phoneValid == false || altPhoneValid == false)
                {
                    MessageBox.Show("Please use proper phone format. Ex. (XXX)-XXX-XXXX");
                }

                if (emailValid == false)
                {
                    MessageBox.Show("Please use proper email format. Ex. someone@example.com");
                }
            }
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.joesAutomotiveDataBaseDataSet.Customer);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
