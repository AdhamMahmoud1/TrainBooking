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
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{

    public partial class UpdateTrain : Form
    {
        static string sql = "Data Source = ADEL; Initial Catalog = BookingTrain; Integrated Security = true; Encrypt=False;";
        SqlConnection con = new SqlConnection(sql);
        public UpdateTrain()
        {
            InitializeComponent();
        }
        public DataTable LoadTrainDetails()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM Train";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            con.Close();
            return table;
        }

        private void UpdateTrain_Load(object sender, EventArgs e)
        {
            dataGridViewForTrains.DataSource = LoadTrainDetails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*private void UpdateButton_Click(object sender, EventArgs e)
        {
            
        }*/

        private void textBoxNumOfSeats_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKinfOfTrain_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewForTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE Train SET kind = @kind, seats = @seats WHERE TrainID= " + dataGridViewForTrains.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@kind", textBoxKindOFTrain.Text);
            command.Parameters.AddWithValue("@seats", textBoxNumOfSeats.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewForTrains.DataSource = LoadTrainDetails();
        }

        private void AdminFormbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(new Admin());
            adminForm.Show();
        }

        private void dataGridViewForTrains_SelectionChanged(object sender, EventArgs e)
        {
            textBoxNumOfSeats.Text = dataGridViewForTrains.CurrentRow.Cells[1].Value.ToString();
            textBoxKindOFTrain.Text = (string)dataGridViewForTrains.CurrentRow.Cells[2].Value;

        }

        private void textBoxNumOfSeats_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
