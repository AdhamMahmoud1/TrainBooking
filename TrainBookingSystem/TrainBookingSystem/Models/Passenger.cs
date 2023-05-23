using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBookingSystem.Models
{
    public class Passenger
    {

        /* Instance Attributes */
        private int passengerId;
        private String userName;
        private String email;
        private String phoneNumber;
        private String gender;
        private String password;


        /*  Constructors */
        public Passenger()
        {
            // init attributes
            this.passengerId = 0;
            this.userName = "None";
            this.email = "None";
            this.phoneNumber = "None";
            this.gender = "male";
            this.password = "None";
        }

        public Passenger(int passengerId, String userName, String email, String phoneNumber, String gender, String password)
        {
            // init attributes
            this.passengerId = passengerId;
            this.userName = userName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.password = password;
        }



        /*  Setters And Getters (encapsulation) */
        public int PassengerId { get { return passengerId ; } set { passengerId = value; } }
        public String Username { get { return userName; } set { userName = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        public String Gender { get { return gender;  } set { gender = value; } }
        public String Password { get { return password; } set { password = value; } }


        /*  Instance Methods */
        public void Print()
        {
            MessageBox.Show($"Id: {this.passengerId}\nName: {this.userName + " "}\nEmail: {this.email}\nPhoneNumber: {this.phoneNumber}\nGender: {this.gender}\nPassword: {this.password}", "Admin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
