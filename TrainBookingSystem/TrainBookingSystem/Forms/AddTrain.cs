using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class AddTrain : Form
    {

        public AddTrain()
        {
            InitializeComponent();
        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();
            String seats = this.textBoxNumOfSeats.Text;
            dbManager.InsertNewTrain(this.textboxKindOfTrain.Text, Convert.ToInt32(seats));
        }

        private void AddTrain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumOfSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
        }

        private void textboxKindOfTrain_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
        }

        private void LoginInHeader_Click(object sender, EventArgs e)
        {
        }
    }
}
