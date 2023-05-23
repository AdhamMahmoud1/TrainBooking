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
        public DataTable LoadTripDetails()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM Trip";
            _dataBaseManager.SqlConnection.Open();

            SqlCommand cmd = new SqlCommand(query, _dataBaseManager.SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            _dataBaseManager.SqlConnection.Close();
            return table;
        }

        private void UpdateTrip_Load(object sender, EventArgs e)
        {
            dataGridViewForTrips.DataSource = LoadTripDetails();
        }


        private void AdminFormbutton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(new Admin());
            adminForm.Show();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _dataBaseManager.SqlConnection.Open();
            String query = "UPDATE Trip SET Source = @source, Destination = @destination,  DepartureTime = @arrivalTime, ArrivalTime = @Date, TrainID = @TrainID  WHERE TID= " + dataGridViewForTrips.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand command = new SqlCommand(query, _dataBaseManager.SqlConnection);
            command.Parameters.AddWithValue("TrainID", textBoxTrainID.Text);
            command.Parameters.AddWithValue("@destination", textBoxDest.Text);
            command.Parameters.AddWithValue("@source", textBoxSource.Text);
            command.Parameters.AddWithValue("@arrivalTime", textBoxArrivalTime.Text);
            command.Parameters.AddWithValue("@Date", textBoxDate.Text);
            command.ExecuteNonQuery();
            _dataBaseManager.SqlConnection.Close();
            MessageBox.Show("Updated Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewForTrips.DataSource = LoadTripDetails();
        }
    }
}

