using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainBookingSystem.User_Controls;

namespace TrainBookingSystem.Forms
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }



        private void LoadControler(UserControl uc)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            uc.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(uc);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // it controls
            UC_DashBoard uC= new UC_DashBoard();
            LoadControler(uC);
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            // it controls
            RegisterTrip uC = new RegisterTrip();
            LoadControler(uC);
        }
    }
}
