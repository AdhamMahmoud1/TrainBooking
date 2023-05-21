using TrainBookingSystem.Services;

namespace TrainBookingSystem.Forms
{
    public partial class Login : Form
    {


        /* Local Attributes */
        private DataBaseManager _dataBaseManager;
        private bool isLoggedInAsAdmin;
        private bool isLoggedInAsCustomer;


        /* Constructors */
        public Login()
        {
            InitializeComponent();

            // initialize database manager
            this._dataBaseManager = new DataBaseManager();

            // initialize isLoggedIn with false untill user loggs in
            this.isLoggedInAsAdmin = false;
            this.isLoggedInAsCustomer = false;
        }


        /* Setters And Getters */
        public DataBaseManager DataBaseManager
        {
            get { return _dataBaseManager; }

            set { _dataBaseManager = value; }
            
        }

        public bool IsLoggedInAsAdmin
        {
            get { return isLoggedInAsAdmin; }
        }

        public bool IsLoggedInAsCustomer
        {
            get { return isLoggedInAsCustomer; }
        }


        /* Instance Methods */
        private void CheckBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            // if password is checked unmask it, else leave it as it is.
            if (CheckBoxShowpassword.Checked)
            {
                this.textBoxPassword.PasswordChar= '\0';
            }
            else
            {
                this.textBoxPassword.PasswordChar= '*';
            }
        }


        private void LoginAsAdminButton_Click(object sender, EventArgs e)
        {

            // validate
            if (IsValidInputFields())
            {
                // check if in database
                if (!this._dataBaseManager.DoElementExistInTable<String>("Admins", "Email", this.textBoxEmail.Text))
                {
                    MessageBox.Show("Unfortunatlly You Are Not An Admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (!this._dataBaseManager.DoElementExistInTable<String>("Admins", "Password", textBoxPassword.Text))
                {
                    MessageBox.Show("Invalid Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // message box, user logged in
                    MessageBox.Show("Succesfully Logged In!, WELCOME Admin.", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Succesfully Logged In!, WELCOME Admin.");

                    // set logged in = true
                    this.isLoggedInAsAdmin = true;
                }
            }
        }

        
        
        private void LoginAsCustomerButton_Click(object sender, EventArgs e)
        {

            // validate
            if (IsValidInputFields())
            {
                // check if in database
                if (!this._dataBaseManager.DoElementExistInTable<String>("Users", "Email", this.textBoxEmail.Text))
                {
                    MessageBox.Show("Unfortunatlly You Are Not A Customer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (!this._dataBaseManager.DoElementExistInTable<String>("Users", "Password", textBoxPassword.Text))
                {
                    MessageBox.Show("Invalid Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // message box, user logged in
                    MessageBox.Show("Succesfully Logged In!, WELCOME Customer.", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Succesfully Logged In!");

                    // set logged in = true
                    this.isLoggedInAsCustomer = true;
                }
            }
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            // create new sign up form and remove current
            new Registration().Show();
            this.Hide();
        }



        ///////////////////////////////////////////////////////////////////////// Helper Functions //////////////////////////////////////////////////////////////////////////

        private bool IsValidInputFields()
        {
            // validator instance 
            Validator validator = new Validator();

            // error message
            String message;


            // flag 
            bool valid = true;

            if (String.IsNullOrEmpty(textBoxEmail.Text.Trim()))
            {

                // email empty error
                message = "Email is required.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valid = false;



            }
            else if (String.IsNullOrEmpty(textBoxPassword.Text.Trim()))
            {
                // password empty error
                message = "Password is required.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valid = false;
            }
            else
            {
                // validate email
                if (!validator.IsValidEmail(textBoxEmail.Text.Trim()))
                {
                    message = "You have entered an invalid e-mail address. Please try again.";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;

                }
            }

            return valid;
        }


        private bool IsValidInputs(string firstName, string email, string phoneNumber, string deparment, string dpLevel, string Dbrith, string Gender, string MStatus, string NumKids, string Specil)
        {
            // declare a validator
            Validator v = new Validator();

            // init answer with true
            bool flag = true;

            if (!v.IsValidName(firstName))
            {
                flag = false;
                string message = "“Not a valid Name (must not be empty and can't include special characters or digits)”";
                System.Windows.Forms.MessageBox.Show(message, "Error");

            }

            else if (!v.IsValidPhoneNumber(phoneNumber))
            {
                flag = false;
                string message = "“Not a valid phone number (must not be empty and not include spaces or special characters)”";
                System.Windows.Forms.MessageBox.Show(message, "Error");
            }
            else if (!v.IsValidEmail(email))
            {
                flag = false;
                string message = "You have entered an invalid e-mail address. Please try again.";
                System.Windows.Forms.MessageBox.Show(message, "Error");
            }

            else { }     // else: do nothing 

            return flag;
        }

    }
}
