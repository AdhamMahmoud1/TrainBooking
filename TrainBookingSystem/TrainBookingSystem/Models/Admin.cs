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
        private string adminSSN;
        private String name;
        private String gender;
        private String email;
        private String phoneNumber;
        private String password;


        /*  Constructors */
        public Admin()
        {
            // init attributes
            this.adminSSN = "None";
            this.name = "None";
            this.gender = "None";
            this.email = "None";
            this.phoneNumber = "None";
            this.password = "None";
        }

        public Admin(string adminSSN, String name, String gender, String email, String phoneNumber, String password)
        {
            // init attributes
            this.adminSSN= adminSSN;
            this.name= name;
            this.gender= gender;
            this.email= email;
            this.phoneNumber= phoneNumber;
            this.password = password;
        }



        /*  Setters And Getters (encapsulation) */
        public string AdminSSN { get { return adminSSN; } set { adminSSN = value; } }
        public String Name { get { return name; } set { name = value; } }
        public String Gender { get { return gender;} set { gender = value; } }
        public String Email { get { return email;} set { email = value; } }
        public String PhoneNumber { get { return phoneNumber;} set { phoneNumber = value; } }
        public String Password { get { return password; } set { password = value; } }


        /*  Instance Methods */
        public void Print()
        {
            MessageBox.Show($"Id: {this.adminSSN}\nName: {this.name }\nGender: {this.Gender}\nEmail: {this.email}\nPhoneNumber: {this.phoneNumber}\nPassword: {this.password}", "Admin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            
            
            

    }
}
