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
using System.Data.SqlClient;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms.Admin_Forms
{
    public partial class UpdateTrain : Form
    {
        DataBaseManager _dataBaseManager;

        public UpdateTrain()
        {
            InitializeComponent();
            this._dataBaseManager = new DataBaseManager();  
        }
        public DataTable LoadTrainDetails()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM Train";
            _dataBaseManager.SqlConnection.Open();
            SqlCommand command = new SqlCommand(query, _dataBaseManager.SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            _dataBaseManager.SqlConnection.Close();
            return table;
        }

        private void UpdateTrain_Load(object sender, EventArgs e)
        {
            dataGridViewForTrains.DataSource = LoadTrainDetails();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _dataBaseManager.SqlConnection.Open();
            String query = "UPDATE Train SET TrainType = @kind, NumberOfSeats = @seats WHERE TrainID= " + dataGridViewForTrains.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand command = new SqlCommand(query, _dataBaseManager.SqlConnection);
            command.Parameters.AddWithValue("@kind", textBoxKindOFTrain.Text);
            command.Parameters.AddWithValue("@seats", textBoxNumOfSeats.Text);
            command.ExecuteNonQuery();
            _dataBaseManager.SqlConnection.Close();
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
    }
}
