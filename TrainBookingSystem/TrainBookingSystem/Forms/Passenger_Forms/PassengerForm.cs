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
using TrainBookingSystem.User_Controls;

namespace TrainBookingSystem.Forms
{
    public partial class PassengerForm : Form
    {
        /* Instance Attributes */
        Passenger passenger;

        public PassengerForm()
        {
            // init form componenets
            InitializeComponent();

            // init passenger
            this.passenger = new Passenger();
        }

        public PassengerForm(Passenger passenger)
        {
            // init form components
            InitializeComponent();

            // init passenger
            this.passenger = passenger;

            // init header credentials from passed in passenger
            this.lblUserName.Text = this.passenger.Username;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // close the form
            Application.Exit();
        }



        private void LoadControler(UserControl uc)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            uc.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(uc);

        }

        private void LoadForm(Form form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            form.TopLevel= false;
            this.mainPanel.Controls.Add(form);
            form.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Dashboard";

            // it controls
            UC_DashBoard uC= new UC_DashBoard();
            LoadControler(uC);
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Book A New Trip";

            // it controls
            RegisterTrip uC = new RegisterTrip(this.passenger);
            LoadControler(uC);
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            // title
            this.lblTitle.Text = "My Trips";

            LoadForm(new MyTripsForm(this.passenger));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            // title
            this.lblTitle.Text = "Profile";

            LoadForm(new MyProfileForm(this.passenger));
        }
    }
}
