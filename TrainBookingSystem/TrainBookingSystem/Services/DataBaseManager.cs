using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Globalization;

namespace TrainBookingSystem.Services
{
    public class DataBaseManager
    {
        private String connectionString;
        private SqlConnection connection;
        private object price;


        /* Constructors */
        public DataBaseManager()                  
        {
            // build the connection
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-FR4U3I0";
            builder.InitialCatalog = "BookingTrain";
            //builder.UserID = "FADYKAMAL/fadyk";
            //builder.Password = "";
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

        public object TrainID { get; private set; }


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

        public bool DoElementExistInTable<T>(string tableName = "Users", string columnName = "Email", T element = default)
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


        public bool InsertNewTrain(String kind = "", int noSeats = 0)
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO Train(kind, seats) VALUES(@kind, @noSeats)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kind", kind);
                    command.Parameters.AddWithValue("@noSeats", noSeats);
                  


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


        public bool InsertNewTrip(int TrainID = 0, String source = "", String destination = "", String date = "", String arrivalDate = "", int price = 0)
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO Trip(TrainID, source, destination, Date, arrivalTime, price) VALUES(@TrainID, @source, @destination, @Date, @arrivalTime, @price)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainID", TrainID);
                    command.Parameters.AddWithValue("@source", source);
                    command.Parameters.AddWithValue("@destination", destination);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@arrivalTime", arrivalDate);
                    command.Parameters.AddWithValue("@price", price);




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



        public bool InsertNewClient(String firstName="", String lastName="", String email="", String phoneNumber="", String password="")
        {
            // flag
            bool inserted = false;

            try
            {
                // new connection
                this.connection.Open();

                // query
                String query = $"INSERT INTO Users(FirstName, LastName, Email, PhoneNumber, Password) VALUES(@firstname, @lastname, @email, @phonenumber, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstname", firstName);
                    command.Parameters.AddWithValue("@lastname", lastName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phonenumber", phoneNumber);
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

        public SqlDataReader GetUserFromDB<T>(String tableName="Users", String columnName="Email", T element=default)
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
       

    }
}
