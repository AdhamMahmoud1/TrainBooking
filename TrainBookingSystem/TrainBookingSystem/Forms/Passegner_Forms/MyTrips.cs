using System.Data;
using System.Data.SqlClient;
using System.Text;
using TrainBookingSystem.Models;
using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class MyTripsForm : Form
    {
        /* Instance attributes */
        private DataBaseManager _dataBaseManager;
        private DataTable _myTrips;
        private Passenger _passenger;

        public MyTripsForm()
        {
            InitializeComponent();

            // init database manager
            this._dataBaseManager = new DataBaseManager();


            // init passenger with defualt values
            this._passenger = new Passenger();

            int id = this._passenger.PassengerId;

            // init datatable
            InitDataTable(id);
        }

        public MyTripsForm(Passenger passenger)
        {
            InitializeComponent();

            // init database manager
            this._dataBaseManager = new DataBaseManager();

            // init passenger
            this._passenger = passenger;

            // fetch passenger id
            int id = this._passenger.PassengerId;

            // init datatable
            InitDataTable(id);

            // init Datagridview
            InitDataGridView();
        }


        // init table
        private void InitDataTable(int passengerId)
        {
            // open connection to database
            this._dataBaseManager.ConnectToDatabase();

            // sql query to retrieve trips related to the passenger
            string query = "SELECT t.*, tb.BookingStatus " +
                               "FROM Trip AS t " +
                               "INNER JOIN TripBookings AS tb ON t.TripId = tb.TripId " +
                               "WHERE tb.PassengerId = @passengerId;";


            try
            {
                // sql adapter to perform sql query
                SqlDataAdapter adapter = new SqlDataAdapter(query, this._dataBaseManager.SqlConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@passengerId", passengerId);

                DataTable data = new DataTable();
                adapter.Fill(data);
                this._myTrips = data;

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

            if (this._myTrips != null)
            {
                // init datagrid view
                this.dataGridViewBookedTrips.DataSource = this._myTrips;

                // Prevent the last empty row from being displayed
                this.dataGridViewBookedTrips.AllowUserToAddRows = false;

            }
        }
        private void buttonCancelTrip_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (this.dataGridViewBookedTrips.SelectedRows.Count > 0)
                {
                    // Get the selected row from the DataGridView
                    DataGridViewRow selectedRow = this.dataGridViewBookedTrips.SelectedRows[0];
                    // check if trip is already canceled
                    if (selectedRow.Cells[6].Value.ToString().Equals("Cancelled"))
                    {
                        MessageBox.Show("Trip Already Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        // Get the TripId from the selected row
                        int tripId = (int)selectedRow.Cells["TripId"].Value;

                        // Cancel the trip in the database
                        if (this._dataBaseManager.CancelTrip(tripId))
                        {
                            // Successful cancellation
                            MessageBox.Show("Trip Canceled Successfully!", "Canceled Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            int passengerId = this._passenger.PassengerId;
                            InitDataTable(passengerId);
                            InitDataGridView();
                        }
                    }
                    
                }
                else
                {
                    // No row selected, show a message
                    MessageBox.Show("Please select the trip you want to cancel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
