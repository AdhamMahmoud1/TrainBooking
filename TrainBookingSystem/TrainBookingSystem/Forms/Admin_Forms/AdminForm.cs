using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainBookingSystem.Models;

namespace TrainBookingSystem.Forms.Admin_Forms
{
    public partial class AdminForm : Form
    {
        Admin admin;

        public AdminForm()
        {
            InitializeComponent();
            this.admin = new Admin();
        }


        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTrain addTrain = new AddTrain();
            addTrain.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTrip addTrip = new AddTrip(this);
            addTrip.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginInHeader_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateTrip updateTrip = new UpdateTrip();
            updateTrip.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTrain addTrain = new AddTrain();
            addTrain.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddTrip addTrip = new AddTrip(this);
            addTrip.Show();
        }
    }
}
