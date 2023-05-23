using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainBookingSystem.Services;


namespace TrainBookingSystem.Forms
{
    public partial class Registration : Form
    {

        /* Local Attributes */
        private DataBaseManager _dataBaseManager;
        private bool isRegistered;


        public Registration()
        {
            // initialize form 
            InitializeComponent();

            // initialize local attribute
            this._dataBaseManager = new DataBaseManager();
            this.isRegistered = false;
        }

        /* Instance Methods */
        private void CheckBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            // if password is checked unmask it, else leave it as it is.
            if (CheckBoxShowpassword.Checked)
            {
                this.textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                this.textBoxPassword.PasswordChar = '*';
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // validate text boxes
            // check if email already in database
            // else. inser it into database

            if (IsValidInputs(this.textBoxUsername.Text, this.textBoxEmail.Text, this.textBoxPhoneNumber.Text, this.textBoxSSN.Text, this.textBoxGender.Text))
            {
                if (this._dataBaseManager.DoElementExistInTable<String>("passenger", "email", this.textBoxEmail.Text))
                {
                    // if in alread in database
                    MessageBox.Show("This User Already Exists In DataBase!");

                    // clear email field
                    this.textBoxEmail.Clear();
                }
                else
                {
                    // insret info into database 
                    if (this._dataBaseManager.InsertNewClient(textBoxUsername.Text, this.textBoxEmail.Text, this.textBoxPhoneNumber.Text, this.textBoxPassword.Text, this.textBoxSSN.Text, this.textBoxGender.Text))
                    {
                        // confverming message
                        MessageBox.Show("!! You Have Been Registered Succefully !!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //set registered = true
                        this.isRegistered = true;

                        // create login form
                        new Login().Show();

                        // close current
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            // create a new login form
            new Login().Show();

            // hide current
            this.Hide();
        }



        ///////////////////////////////////////////////////////////////////////// Helper Functions //////////////////////////////////////////////////////////////////////////

        private bool IsEmptyInputs()
        {

            // error message
            String message;


            // flag 
            bool valid = true;

            if (String.IsNullOrEmpty(textBoxUsername.Text.Trim()))
            {

                // UserName empty error
                message = "Username is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;



            }
            else if (String.IsNullOrEmpty(textBoxEmail.Text.Trim()))
            {

                // email empty error
                message = "Email is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else if (String.IsNullOrEmpty(textBoxPhoneNumber.Text.Trim()))
            {

                // Phone empty error
                message = "Phone number is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else if (String.IsNullOrEmpty(textBoxGender.Text.Trim()))
            {
                // Gender empty error
                message = "Gender is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else if (String.IsNullOrEmpty(textBoxSSN.Text.Trim()))
            {
                // Gender empty error
                message = "SSN is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else if (String.IsNullOrEmpty(textBoxPassword.Text.Trim()))
            {
                // password empty error
                message = "Password is required.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else { }


            return valid;
        }




        public static bool IsValidInputs(string userName, string email, string phoneNumber, string SSN, string Gender)
        {
            // declare a validator
            Validator v = new Validator();

            // error message
            String message;

            // init answer with true
            bool flag = true;

            if (!v.IsValidName(userName))
            {
                flag = false;
                message = "“Not a valid Name (must not be empty and can't include special characters or digits)”";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!v.IsValidEmail(email))
            {
                flag = false;
                message = "You have entered an invalid e-mail address. Please try again.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!v.IsValidPhoneNumber(phoneNumber))
            {
                flag = false;
                message = "“Not a valid phone number (must not be empty and not include spaces or special characters)”";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!v.IsValidGender(Gender))
            {
                flag = false;
                message = "“Not a valid Gender”. The Gender Can Be Female or Male";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!v.IsValidSSN(SSN))
            {
                flag = false;
                message = "Not a valid SSN, Please try again.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { }

            return flag;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lablePassword_Click(object sender, EventArgs e)
        {

        }

    }
}
