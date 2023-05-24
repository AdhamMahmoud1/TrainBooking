using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainBookingSystem.Models;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class MyProfileForm : Form
    {
        /* Instance attributes */
        private Passenger _passenger;

        public MyProfileForm()
        {
            // init form componenet
            InitializeComponent();

            // init instance attributes
            this._passenger = new Passenger();
        }


        public MyProfileForm(Passenger passenger)
        {
            // init form componenet
            InitializeComponent();

            // init instance attributes
            this._passenger = passenger;
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            // refetech passenger by id;
            DataBaseManager db = new DataBaseManager();
            this._passenger = db.GetPassengerFromDataBaseById(this._passenger.PassengerId);

            this.labelPassengerId.Text = _passenger.PassengerId.ToString();
            this.labelUsername.Text = _passenger.Username;
            this.labelEmail.Text = _passenger.Email;
            this.labelPhoneNumber.Text = _passenger.PhoneNumber;
            this.label.Text = _passenger.Gender;
            this.labelPassword.Text = _passenger.Password;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpatePassengerInfoForm form = new UpatePassengerInfoForm(this._passenger);
            form.ShowDialog();

            // reload form
            MyProfileForm_Load(this, EventArgs.Empty);
        }
    }
}
