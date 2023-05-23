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
    public partial class AddTrain : Form
    {
        public AddTrain()
        {
            InitializeComponent();
        }

        private void AddTrain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();
            String seats = this.textBoxNumberOfSeats.Text;
            dbManager.InsertNewTrain(this.textBoxKindOfTrain.Text, Convert.ToInt32(seats));
        }

        private void AdminFormbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(new Admin());
            adminForm.Show();
        }
    }
}
