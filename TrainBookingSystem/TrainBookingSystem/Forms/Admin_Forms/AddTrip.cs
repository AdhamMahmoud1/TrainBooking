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
        public AddTrip(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        public AddTrip()
        {
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void AddTrainButton_Click(object sender, EventArgs e)
        {

            DataBaseManager db = new DataBaseManager();
            int TrainID = Convert.ToInt32(this.textBoxTrainID.Text);
            int Price =Convert.ToInt32(this.textBoxPrice.Text);
           
           db.InsertNewTrip(TrainID, this.textBoxSource.Text, this.textBoxDest.Text, this.textboxDate.Text, this.textBoxArrival.Text, Price);
            MessageBox.Show("Trip Added Successfully");
            this.Close();
            adminForm.Show();
        }

        private void textBoxArrival_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTrip_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
