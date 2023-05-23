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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTrain train = new AddTrain();
            train.Show();
        }

        private void UpdateTrainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTrain train = new UpdateTrain();
            train.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
