using Microsoft.Data.SqlClient;
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

namespace TrainBookingSystem.Forms
{
    public partial class UpdateTrip : Form
    {
        static string sql = "Data Source = ADEL; Initial Catalog = BookingTrain; Integrated Security = true; Encrypt=False;";
        SqlConnection con = new SqlConnection(sql);
        public UpdateTrip()
        {
            InitializeComponent();
        }
        public DataTable LoadTripDetails()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM Trip";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();
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
            con.Open();
            String query = "UPDATE Trip SET TrainID = @TrainID, source = @source, destination = @destination, arrivalTime = @arrivalTime, Date = @Date, price = @price  WHERE TID= " + dataGridViewForTrips.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("TrainID", textBoxTrainID.Text);
            command.Parameters.AddWithValue("@destination", textBoxDest.Text);
            command.Parameters.AddWithValue("@source", textBoxSource.Text);
            command.Parameters.AddWithValue("@arrivalTime", textBoxArrivalTime.Text);
            command.Parameters.AddWithValue("@Date", textBoxDate.Text);
            command.Parameters.AddWithValue("@price", textBoxPrice.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewForTrips.DataSource = LoadTripDetails();
        }
    }
}
