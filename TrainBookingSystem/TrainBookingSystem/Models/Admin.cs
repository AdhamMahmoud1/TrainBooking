using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBookingSystem.Models
{
    public class Admin
    {
        /* Instance Attributes */
        private int adminId;
        private String firstName;
        private String lastName;
        private String email;
        private String phoneNumber;
        private String password;


        /*  Constructors */
        public Admin()
        {
            // init attributes
            this.adminId = 0;
            this.firstName = "None";
            this.lastName = "None";
            this.email = "None";
            this.phoneNumber = "None";
            this.password = "None";
        }

        public Admin(int adminId, String firstName, String lastName, String email, String phoneNumber, String password)
        {
            // init attributes
            this.adminId= adminId;
            this.firstName= firstName;
            this.lastName= lastName;
            this.email= email;
            this.phoneNumber= phoneNumber;
            this.password = password;
        }



        /*  Setters And Getters (encapsulation) */
        public int AdminId { get { return adminId;} set { adminId = value; } }
        public String FirstName { get { return firstName;} set { firstName = value; } }
        public String LastName { get { return lastName;} set { lastName = value; } }
        public String Email { get { return email;} set { email = value; } }
        public String PhoneNumber { get { return phoneNumber;} set { phoneNumber = value; } }
        public String Password { get { return password; } set { password = value; } }


        /*  Instance Methods */
        public void Print()
        {
            MessageBox.Show($"Id: {this.adminId}\nName: {this.firstName + " " + this.lastName}\nEmail: {this.email}\nPhoneNumber: {this.phoneNumber}\nPassword: {this.password}", "Admin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            
            
            

    }
}
