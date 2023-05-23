using ServiceStack.Text;
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

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Dashboard";

            // it controls
            UC_DashBoard uC= new UC_DashBoard();
            LoadControler(uC);
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Register New Trip";

            // it controls
            RegisterTrip uC = new RegisterTrip(this.passenger);
            LoadControler(uC);
        }

    }
}
