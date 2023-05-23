using System.Data.SqlClient;
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

namespace TrainBookingSystem.User_Controls
{
    public partial class RegisterTrip : UserControl
    {
        /* Instance attributes */
        DataBaseManager _dataBaseManager;
        DataTable _trips;

        public RegisterTrip()
        {
            InitializeComponent();

            // init database manager
            this._dataBaseManager= new DataBaseManager();

            // init datatable
            InitDataTable();
        }

        private void RegisterTrip_Load(object sender, EventArgs e)
        {

            // init comoboxe from
            InitComboBox("Source", this.comboBoxFrom);

            // init comoboxe to
            InitComboBox("Destination", this.comboBoxTo);

            // init datagrid view
            InitDataGridView();
        }

        private void InitComboBox(string columnName, ComboBox comboBox)
        {
            // Open connection to the database
            this._dataBaseManager.ConnectToDatabase();

            // SQL query
            string query = $"SELECT DISTINCT [{columnName}] FROM Trip";

            try
            {
                // SQL adapter to perform SQL query
                SqlDataAdapter adapter = new SqlDataAdapter(query, this._dataBaseManager.SqlConnection);

                // Fill DataTable with query results
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Clear existing items in the ComboBox
                comboBox.Items.Clear();

                // Iterate over DataTable rows and add values to ComboBox
                foreach (DataRow row in data.Rows)
                {
                    string value = row[0].ToString();
                    comboBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection after retrieving data
                this._dataBaseManager.Disconnect();
            }
        }


        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected value from the ComboBox
                string selectedValue = this.comboBoxFrom.SelectedItem.ToString();

                // Filter the data source based on the selected value
                DataView filteredView = new DataView(this._trips);
                filteredView.RowFilter = $"Source = '{selectedValue}'";

                // Update the DataGridView's data source
                this.dataGridViewTripsWithSourceAndDistination.DataSource = filteredView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected value from the ComboBoxes
                string sourceValue = this.comboBoxFrom.Text;
                string destinationValue = this.comboBoxTo.Text;

                // Filter the data source based on the selected values
                DataView filteredView = new DataView(this._trips);
                filteredView.RowFilter = $"Source = '{sourceValue}' AND Destination = '{destinationValue}'";

                // Update the DataGridView's data source
                this.dataGridViewTripsWithSourceAndDistination.DataSource = filteredView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // init table
        private void InitDataTable()
        {
            // open connection to database
            this._dataBaseManager.ConnectToDatabase();

            // sql query
            String query = "SELECT * FROM Trip";

            try
            {
                // sql adapter to perform sql query
                SqlDataAdapter adapter = new SqlDataAdapter(query, this._dataBaseManager.SqlConnection);

                DataTable data = new DataTable();
                adapter.Fill(data);
                this._trips = data;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close connection
                this._dataBaseManager.Disconnect();
            }
        }

        private void InitDataGridView()
        {
            if (_trips != null)
            {
                this.dataGridViewTripsWithSourceAndDistination.DataSource = this._trips;

            }
        }

        private void buttonRegisterTrip_Click(object sender, EventArgs e)
        {
            // insert into Trip Bookings

        }
    }
}
