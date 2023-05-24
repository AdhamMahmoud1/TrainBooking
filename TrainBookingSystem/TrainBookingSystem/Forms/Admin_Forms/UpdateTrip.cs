using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TrainBookingSystem.Models;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms.Admin_Forms
{
    public partial class UpdateTrip : Form
    {
        DataBaseManager _dataBaseManager;
        public UpdateTrip()
        {
            InitializeComponent();
        }
       

      

      
        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseManager dataBaseManager = new DataBaseManager();
            int TripID = Convert.ToInt32(textBoxTripID.Text);
            int TrainID = Convert.ToInt32(textBoxTrainID.Text);
            dataBaseManager.UpdateTrip(TripID, TrainID, textBoxSource.Text, textBoxDest.Text, textBoxDate.Text, textBoxArrival.Text);
            MessageBox.Show("Updated Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            AdminForm admin = new AdminForm(new Admin());
            admin.Show();
        }
    }
}

