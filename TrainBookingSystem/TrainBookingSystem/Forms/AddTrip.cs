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
    public partial class AddTrip : Form
    {
        public AddTrip()
        {
            InitializeComponent();
        }

        private void AddTrip_Load(object sender, EventArgs e)
        {

        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            DataBaseManager db = new DataBaseManager();
            int TrainID = Convert.ToInt32(this.textBoxTrainID.Text);
            int Price = Convert.ToInt32(this.textBoxPrice.Text);

            db.InsertNewTrip(TrainID, this.textBoxSource.Text, this.textBoxDest.Text, this.textboxDate.Text, this.textBoxArrival.Text, Price);
            MessageBox.Show("Trip Added Successfully");
        }

        private void AdminFormbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(new Admin());
            adminForm.Show();
        }
    }
}
