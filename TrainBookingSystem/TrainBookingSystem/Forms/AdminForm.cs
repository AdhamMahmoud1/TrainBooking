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

namespace TrainBookingSystem.Forms
{
    public partial class AdminForm : Form
    {
        private Admin admin;

        public AdminForm(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            AddTrain train = new AddTrain();
            train.Show();
            this.Hide();
        }

        private void UpdateTrainButton_Click(object sender, EventArgs e)
        {

            UpdateTrain train = new UpdateTrain();
            train.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            AddTrip trip = new AddTrip();
            trip.Show();
            this.Hide();
        }

        private void UpdateTripButton_Click(object sender, EventArgs e)
        {
            UpdateTrip trip = new UpdateTrip();
            trip.Show();
            this.Hide();
        }

    }
}
