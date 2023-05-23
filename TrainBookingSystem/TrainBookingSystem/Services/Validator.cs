using System.Text.RegularExpressions;

namespace TrainBookingSystem.Services
{
    class Validator
    {
        /* Instance Attributes */
        private string m_Str;
        Regex rgx;


        /* Construrctors */
        public Validator()                                    // Defualt constructor
        {
            m_Str = "";
            rgx = new Regex("^$");
        }


        public Validator(string str)                           // Parameterized constructor
        {
            m_Str = str;
            rgx = new Regex("^$");
        }


        /* Setters And Getters */
        public void setString(string str)
        {
            m_Str = str;
        }


        public string getString() { return m_Str; }


        /* Instance Methods */
        public bool IsValidName(string name)
        {

            // create a regex pattern to match the entered name with
            rgx = new Regex(@"^[a-zA-Z'-]");

            // if is match return true else return the predefined answer = false
            return rgx.IsMatch(name);
        }


        public bool IsValidPhoneNumber(string phoneNumber)
        {

            // create a regex pattern to match the entered phone number with
            rgx = new Regex(@"^(010|011|012|015)\d{8}$");

            // if is match return true else return the predefined answer = false
            return rgx.IsMatch(phoneNumber);

        }


        public bool IsValidEmail(string email)
        {

            // create a regex pattern to match the entered email with
            rgx = new Regex(@"^([\w\-\.]+)@((\[([0-9]{1,3}\.){3}[0-9]{1,3}\])|(([\w\-]+\.)+)([a-zA-Z]{2,4}))$");

            // if is match return true else return the predefined answer = fals
            return rgx.IsMatch(email);

        }

    }
}
