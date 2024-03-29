﻿using System.Data.SqlClient;
using TrainBookingSystem.Models;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class Login : Form
    {


        /* Local Attributes */
        private DataBaseManager _dataBaseManager;
        private bool isLoggedInAsAdmin;
        private bool isLoggedInAsCustomer;


        /* Constructors */
        public Login()
        {
            InitializeComponent();

            // initialize database manager
            this._dataBaseManager = new DataBaseManager();

            // initialize isLoggedIn with false untill user loggs in
            this.isLoggedInAsAdmin = false;
            this.isLoggedInAsCustomer = false;
        }


        /* Setters And Getters */
        public DataBaseManager DataBaseManager
        {
            get { return _dataBaseManager; }

            set { _dataBaseManager = value; }

        }

        public bool IsLoggedInAsAdmin
        {
            get { return isLoggedInAsAdmin; }
        }

        public bool IsLoggedInAsCustomer
        {
            get { return isLoggedInAsCustomer; }
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


        private void LoginAsAdminButton_Click(object sender, EventArgs e)
        {

            // validate
            if (IsValidInputFields())
            {
                // check if in database
                if (!this._dataBaseManager.DoElementExistInTable<String>("Admin", "Email", this.textBoxEmail.Text))
                {
                    MessageBox.Show("Unfortunatlly You Are Not An Admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (!this._dataBaseManager.DoElementExistInTable<String>("Admin", "Password", textBoxPassword.Text))
                {
                    MessageBox.Show("Invalid Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (this._dataBaseManager.DoesUserExistInTable<String>("Admin", this.textBoxEmail.Text, this.textBoxPassword.Text))
                    {
                        // message box, user logged in
                        MessageBox.Show("Succesfully Logged In!, WELCOME Admin.", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // set logged in = true
                        this.isLoggedInAsAdmin = true;

                        // call admin form
                    }
                    else
                    {
                        MessageBox.Show("Unfortunatlly You Are Not An Admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



        private void LoginAsCustomerButton_Click(object sender, EventArgs e)
        {

            // validate
            if (IsValidInputFields())
            {
                // check if in database
                if (!this._dataBaseManager.DoElementExistInTable<String>("Passenger", "Email", this.textBoxEmail.Text))
                {
                    MessageBox.Show("Unfortunatlly You Are Not A Customer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (!this._dataBaseManager.DoElementExistInTable<String>("Passenger", "Password", textBoxPassword.Text))
                {
                    MessageBox.Show("Invalid Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (this._dataBaseManager.DoesUserExistInTable<String>("Passenger", this.textBoxEmail.Text, this.textBoxPassword.Text))
                    {
                        // message box, user logged in
                        MessageBox.Show("Succesfully Logged In!, WELCOME Passenger.", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // set logged in = true
                        this.isLoggedInAsCustomer = true;

                        Passenger passenger = this._dataBaseManager.GetPassengerFromDataBase(this.textBoxEmail.Text);

                        // hide login form
                        this.Hide();

                        
                        // call customer form
                        PassengerForm passn= new PassengerForm(passenger);
                        passn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unfortunatlly You Are Not An Cusomter", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            // create new sign up form and remove current
            new Registration().Show();
            this.Hide();
        }



        public Admin GetLoggedinAdminFromDB()
        {
            // empty admin
            Admin admin = new Admin();

            try
            {
                // get reader from database
                SqlDataReader reader = this._dataBaseManager.GetUserFromDB<String>("Admin", "Email", this.textBoxEmail.Text);

                if (this.isLoggedInAsAdmin)
                {
                    // store featched in amdin
                    while (reader.Read())
                    {
                        admin.AdminId = (int)reader.GetValue(0);
                        admin.Username = (string)reader.GetValue(1);
                        admin.Email = (string)reader.GetValue(2);
                        admin.PhoneNumber = (string)reader.GetValue(3);
                        admin.Password = (string)reader.GetValue(4);
                    }
                }
                else
                {
                    // print admin hasn't signed in yet
                    MessageBox.Show("Admin Hasn't LoggedIn Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // close connection
            this._dataBaseManager.Disconnect();

            return admin;
        } 
        


        ///////////////////////////////////////////////////////////////////////// Helper Functions //////////////////////////////////////////////////////////////////////////

        private bool IsValidInputFields()
        {
            // validator instance 
            Validator validator = new Validator();

            // error message
            String message;


            // flag 
            bool valid = true;

            if (String.IsNullOrEmpty(textBoxEmail.Text.Trim()))
            {

                // email empty error
                message = "Email is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valid = false;



            }
            else if (String.IsNullOrEmpty(textBoxPassword.Text.Trim()))
            {
                // password empty error
                message = "Password is required.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valid = false;
            }
            else
            {
                // validate email
                if (!validator.IsValidEmail(textBoxEmail.Text.Trim()))
                {
                    message = "You have entered an invalid e-mail address. Please try again.";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;

                }
            }

            return valid;
        }


        private bool IsValidInputs(string firstName, string email, string phoneNumber, string deparment, string dpLevel, string Dbrith, string Gender, string MStatus, string NumKids, string Specil)
        {
            // declare a validator
            Validator v = new Validator();

            // init answer with true
            bool flag = true;

            if (!v.IsValidName(firstName))
            {
                flag = false;
                string message = "“Not a valid Name (must not be empty and can't include special characters or digits)”";
                System.Windows.Forms.MessageBox.Show(message, "Error");

            }

            else if (!v.IsValidPhoneNumber(phoneNumber))
            {
                flag = false;
                string message = "“Not a valid phone number (must not be empty and not include spaces or special characters)”";
                System.Windows.Forms.MessageBox.Show(message, "Error");
            }
            else if (!v.IsValidEmail(email))
            {
                flag = false;
                string message = "You have entered an invalid e-mail address. Please try again.";
                System.Windows.Forms.MessageBox.Show(message, "Error");
            }

            else { }     // else: do nothing 

            return flag;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
