using System.Diagnostics;
using TrainBookingSystem.Models;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class UpatePassengerInfoForm : Form
    {
        /* Instance attributes */
        private DataBaseManager _dataBaseManager;
        private Passenger _passenger;
        private String currentEmail;

        public UpatePassengerInfoForm()
        {
            InitializeComponent();

            // init instance attributes
            this._passenger = new Passenger();
            this._dataBaseManager = new DataBaseManager();
            currentEmail = this._passenger.Email;
        }


        public UpatePassengerInfoForm(Passenger passenger)
        {
            InitializeComponent();

            // init instance attributes
            this._passenger = passenger;
            this._dataBaseManager = new DataBaseManager();
            currentEmail = passenger.Email;
        }


        public UpatePassengerInfoForm(String passengerEmail)
        {
            InitializeComponent();

            // init instance attributes
            this._dataBaseManager = new DataBaseManager();
            this._passenger = this._dataBaseManager.GetPassengerFromDataBase(passengerEmail);
            currentEmail = passengerEmail;

        }

        private void UpatePassengerInfoForm_Load(object sender, EventArgs e)
        {
            this._passenger = (Passenger)this._dataBaseManager.GetPassengerFromDataBase(currentEmail);


            if (_passenger != null)
            {
                // init place holders for all boxes
                this.labelPassengerId.Text = _passenger.PassengerId.ToString();
                this.textBoxUsername.Text = _passenger.Username;
                this.textBoxEmail.Text = _passenger.Email;
                this.textBoxPhoneNumber.Text = _passenger.PhoneNumber;
                this.textBoxPassword.Text = _passenger.Password;
                this.comboBox1.SelectedItem = _passenger.Gender;
            }
        }

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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool updateIt = true;

            if (Registration.IsValidInputs(this.textBoxUsername.Text, this.textBoxEmail.Text, this.textBoxPhoneNumber.Text))
            {
                if (this._dataBaseManager.DoElementExistInTable<String>("Passenger", "Email", this.textBoxEmail.Text))
                {
                    // how if used by another user
                    if (this._dataBaseManager.NumberOfExistance<String>("Passenger", "Email", this.textBoxEmail.Text) > 1)
                    {
                        // if in alread in database
                        MessageBox.Show("This Email Is Used By Another User Already Exists In DataBase!");

                        updateIt = false;

                        // clear email field
                        this.textBoxEmail.Clear();
                    }
                }
                if (this._dataBaseManager.DoElementExistInTable<String>("Passenger", "PhoneNumber", this.textBoxPhoneNumber.Text))
                {
                    // how if used by another user
                    if (this._dataBaseManager.NumberOfExistance<String>("Passenger", "PhoneNumber", this.textBoxPhoneNumber.Text) > 1)
                    {
                        // if in alread in database
                        MessageBox.Show("This Phone Number Is Used By Another User In DataBase!");
                        updateIt = false;

                        // clear email field
                        this.textBoxPhoneNumber.Clear();
                    }
                }

                if (updateIt)
                {
                    // insret info into database
                    if (!this._dataBaseManager.UpdatePassengerInformation("Username", this.textBoxUsername.Text, this._passenger.PassengerId))
                    {
                        MessageBox.Show("Something Went Wrong While Updating Username !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsername.Clear();
                    }
                    else if (!this._dataBaseManager.UpdatePassengerInformation("Email", this.textBoxEmail.Text, this._passenger.PassengerId))
                    {
                        MessageBox.Show("Something Went Wrong While Updating Email !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.Clear();
                    }
                    else if (!this._dataBaseManager.UpdatePassengerInformation("PhoneNumber", this.textBoxPhoneNumber.Text, this._passenger.PassengerId))
                    {
                        MessageBox.Show("Something Went Wrong While updating PhoneNumber !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPhoneNumber.Clear();
                    }
                    else if (!this._dataBaseManager.UpdatePassengerInformation("Gender", this.comboBox1.Text, this._passenger.PassengerId))
                    {
                        MessageBox.Show("Something Went Wrong While Updating Gender !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!this._dataBaseManager.UpdatePassengerInformation("Password", this.textBoxPassword.Text, this._passenger.PassengerId))
                    {
                        MessageBox.Show("Something Went Wrong While updating Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBoxPassword.Clear();
                    }
                    else
                    {
                        // confverming message
                        MessageBox.Show("!! Information Updated Successfully !!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.currentEmail = this.textBoxEmail.Text;
                    }
                }
            }
        }
    }
}
