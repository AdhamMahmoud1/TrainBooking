using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBookingSystem.Forms;

namespace TrainBookingSystem.Models
{
    class Manager
    {
        public void run()
        {
            Login login = new Login();
            login.Show();
            if (login.IsLoggedInAsAdmin)
            {
                adminDisplay();
            }
            else if (login.IsLoggedInAsCustomer)
            {
                passengerDisplay();
            }
                
            
        }
        private void adminDisplay() { }
        private void passengerDisplay() { }

           
       




    }
}