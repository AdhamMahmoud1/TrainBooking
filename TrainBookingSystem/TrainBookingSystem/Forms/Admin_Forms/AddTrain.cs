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

namespace TrainBookingSystem.Forms.Admin_Forms
{
    public partial class AddTrain : Form
    {
        public AddTrain()
        {
            InitializeComponent();
        }

        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();
            String seats = this.textBoxNumOfSeats.Text;

            if(dbManager.InsertNewTrain(this.textboxKindOfTrain.Text, Convert.ToInt32(seats)))
            {
                MessageBox.Show("!! Train Added Successfully !!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("!! Somthing  Went Wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
