using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;
using System.Data.SqlClient;
using TrainBookingSystem.Models;

namespace TrainBookingSystem.Services
{
    public class DataBaseManager
    {
        private String connectionString;
        private SqlConnection connection;


        /* Constructors */
        public DataBaseManager()                  
        {
            // build the connection
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "FADYKAMAL";
            builder.InitialCatalog = "TrainBookingSystem";
            builder.TrustServerCertificate= true;
            builder.IntegratedSecurity = true;
            this.connectionString = builder.ToString();


            // initialize the connection
            this.connection = new SqlConnection(connectionString);

        }

        public DataBaseManager(String server, String database, String userName, String password)       
        {
            // build the connection
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource= server;
            builder.InitialCatalog= database; 
            builder.UserID = userName;
            builder.Password= password;
            builder.TrustServerCertificate = true;
            this.connectionString = builder.ToString();   


            // initialize the connection
            this.connection = new SqlConnection(connectionString);
        }

        /* Setters and Getters (encapsulation) */
        public String ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SqlConnection SqlConnection
        {
            get { return connection; }
            set
            {
                connection = value;
            }
        }


        /* Insatnce Methods */
        public bool ConnectToDatabase()
        {
            try
            {
                // try open connection
                this.connection.Open();

                // confirming message
                Console.WriteLine("!! Connected To Database !!");
                return true;
            }
            catch (Exception ex)
            {
                // error message
                Console.WriteLine("!! Error connecting to database:  " + ex.Message);
                return false;
            }
                
        }

        public bool IsConnected() 
        {
            return (this.connection.State == System.Data.ConnectionState.Open);
        }


        public void Disconnect()
        {
            if (IsConnected())
            {
                this.connection.Close();
                Console.WriteLine("!! Disconnected From Database !!");
            }
        }

        public bool DoElementExistInTable<T>(string tableName = "Passenger", string columnName = "Email", T element = default)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ElementValue";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ElementValue", element);

                    int count = 0;

                    try
                    {
                        count = (int)command.ExecuteScalar();

                    }
                    catch (Exception ex)
                    {
                        // Handle the exception appropriately for your application type
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    exists = (count > 0);
                }

                connection.Close();
            }

            return exists;
        }

        public int NumberOfExistance<T>(string tableName = "Passenger", string columnName = "Email", T element = default)
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ElementValue";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ElementValue", element);

                        count = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately for your application type
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return count;
        }



        public bool DoesUserExistInTable<T>(string tableName="Passenger", String email="", String password="")
        {
            bool exists = false;
            

            // get user from database
            SqlDataReader reader = GetUserFromDB<String>(tableName, "Email", email);

            if (reader != null)
            {
                // then  check if credengitals through featched row
                if (reader.Read()) 
                {
                    exists = (reader.GetValue(2).ToString() == email && reader.GetValue(5).ToString() == password);
                }

            }

            reader.Close();
            return exists;
        }



        public bool InsertNewPassenger(String username = "", String email="", String phoneNumber="", String gender="male", String password="")
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO Passenger(Username, Email, PhoneNumber, Gender, Password) VALUES(@username, @email, @phoneNumber, @gender, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phonenumber", phoneNumber);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@password", password);


                    // get number of row affected to know if they been inserted or not
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0) { inserted = true; }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // close connection
            this.connection.Close();

            // return flag
            return inserted;
        }

        public bool InsertNewPassenger(Passenger passenger)
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO Passenger(Username, Email, PhoneNumber, Gender, Password) VALUES(@username, @email, @phoneNumber, @gender, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", passenger.Username);
                    command.Parameters.AddWithValue("@email", passenger.Email);
                    command.Parameters.AddWithValue("@phonenumber", passenger.PhoneNumber);
                    command.Parameters.AddWithValue("@gender", passenger.Gender);
                    command.Parameters.AddWithValue("@password", passenger.Password);


                    // get number of row affected to know if they been inserted or not
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0) { inserted = true; }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // close connection
            this.connection.Close();

            // return flag
            return inserted;
        }

        public bool UpdatePassengerInformation(string columnName, string info, int passengerId)
        {
            bool updated = false;

            try
            {
                connection.Open(); // Open the connection

                string query = $"UPDATE Passenger SET {columnName} = @info WHERE PassengerId = @passengerId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@info", info);
                    command.Parameters.AddWithValue("@passengerId", passengerId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        updated = true;
                    }
                }

                connection.Close(); // Close the connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return updated;
        }




        public bool CancelTrip(int TripId=1)
        {
            // flag
            bool canceled = false;

            try
            {
                // new connection
                ConnectToDatabase();

                // query
                String query = "Update TripBookings SET BookingStatus='Cancelled' WHERE TripId=@TripId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripId", TripId);

                    // get number of row affected to know if they been inserted or not
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0) { canceled = true; }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Disconnect();
            }

            // return flag
            return canceled;
        }

        public bool InsertBookedTrip(int passengerId=0, int TripId = 0, DateTime BookingDate = new DateTime())
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO TripBookings(PassengerId, TripId, BookingDate) VALUES(@PassengerId, @TripId, @BookingDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PassengerId", passengerId);
                    command.Parameters.AddWithValue("@TripId", TripId);
                    command.Parameters.AddWithValue("@BookingDate", BookingDate);


                    // get number of row affected to know if they been inserted or not
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0) { inserted = true; }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close connection
                this.connection.Close();
            }

            // return flag
            return inserted;
        }

        public SqlDataReader GetUserFromDB<T>(String tableName= "Passenger", String columnName="Email", T element=default)
        {
            SqlDataReader reader = null;

            // connect to database
            ConnectToDatabase();

            // query 
            String query = $"SELECT * FROM {tableName} WHERE {columnName} = @ElementValue";


            // exute command
            using (SqlCommand command = new SqlCommand(query, this.SqlConnection))
            {
                // replace @element valude with element name
                command.Parameters.AddWithValue("@ElementValue", element);

                // store return in reader
                try
                {
                    reader= command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately for your application type
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            // reutrn datareader
            return reader;
        }


        public Passenger GetPassengerFromDataBase(string userEmail = "Email")
        {
            // Connect to database
            ConnectToDatabase();

            // Query 
            string query = $"SELECT * FROM Passenger WHERE Email = @ElementValue";

            // Execute command
            using (SqlCommand command = new SqlCommand(query, this.SqlConnection))
            {
                // Replace @ElementValue with userEmail
                command.Parameters.AddWithValue("@ElementValue", userEmail);

                // Store return in reader
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Passenger pass = new Passenger(
                            (int)reader.GetValue(0),
                            reader.GetValue(1).ToString(),
                            reader.GetValue(2).ToString(),
                            reader.GetValue(3).ToString(),
                            reader.GetValue(4).ToString(),
                            reader.GetValue(5).ToString()
                        );
                        return pass;
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately for your application type
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close connection
                    Disconnect();
                }
            }

            return new Passenger();
        }

        public Passenger GetPassengerFromDataBaseById(int id = 1)
        {
            // Connect to database
            ConnectToDatabase();

            // Query 
            string query = $"SELECT * FROM Passenger WHERE PassengerId = @ElementValue";

            // Execute command
            using (SqlCommand command = new SqlCommand(query, this.SqlConnection))
            {
                // Replace @ElementValue with userEmail
                command.Parameters.AddWithValue("@ElementValue", id);

                // Store return in reader
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Passenger pass = new Passenger(
                            (int)reader.GetValue(0),
                            reader.GetValue(1).ToString(),
                            reader.GetValue(2).ToString(),
                            reader.GetValue(3).ToString(),
                            reader.GetValue(4).ToString(),
                            reader.GetValue(5).ToString()
                        );
                        return pass;
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately for your application type
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close connection
                    Disconnect();
                }
            }

            return new Passenger();
        }



        //public Passenger GetAdminFromDataBase(String userEmail = "Email")
        //{
        //    SqlDataReader reader = null;

        //    // connect to database
        //    ConnectToDatabase();

        //    // query 
        //    String query = $"SELECT * FROM Admin WHERE Email = @ElementValue";


        //    // exute command
        //    using (SqlCommand command = new SqlCommand(query, this.SqlConnection))
        //    {
        //        // replace @element valude with element name
        //        command.Parameters.AddWithValue("@ElementValue", userEmail);

        //        // store return in reader
        //        try
        //        {
        //            reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {

        //                Admin pass = new Admin((int)reader.GetValue(0), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5),ToString());
        //                return pass;

        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle the exception appropriately for your application type
        //            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return null;

        //}


    }
}
