using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class RegularUser : User 
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string profession { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public int sugarLevel { get; set; }
        public int cholesterolLevel { get; set; }
        public int bloodPreassure { get; set; }

        public RegularUser(string email, string password, bool loginStatus, DateTime registerDate)
        {
            this.email = email;
            this.password = password;
            this.loginStatus = loginStatus;
            this.registerDate = registerDate;
        }


        public override void register()
        {

        }
        public override void login()
        {
            
        }

        public void updateProfile()
        {

        }

        public void updateData()
        {

        }

    }
}
