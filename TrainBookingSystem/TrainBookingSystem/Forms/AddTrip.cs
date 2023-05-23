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
    public partial class AddTrip : Form
    {
        private AdminForm adminForm;
        public AddTrip(AdminForm admin)
        {
            InitializeComponent(GetAddTripButton());
            this.adminForm = admin;
        }

        private void AddTrip_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3Date_Click(object sender, EventArgs e)
        {

        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            DataBaseManager db = new DataBaseManager();
            db.InsertNewTrip(Convert.ToInt32(this.textBox5TrainID.Text), this.textBoxNumOfSource.Text, this.textboxDestination.Text, Convert.ToDateTime(this.textBox2Date.Text), Convert.ToDateTime(this.textBox4ArrivalDate.Text), Convert.ToDecimal(this.textBox3Price.Text));
            MessageBox.Show("Trip Added Successfully");
            this.Close();
            adminForm.Show();

        }

        private void textBox5TrainID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumOfSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
