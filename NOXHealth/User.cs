using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    public abstract class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool loginStatus { get; set; }
        public DateTime registerDate { get; set; }

        public User (string email, string password, bool loginStatus, DateTime registerDate)
        {
            this.email = email;
            this.password = password;
            this.loginStatus = loginStatus;
            this.registerDate = registerDate;
        }

        public abstract void register();
        public abstract void login();




    }
}
