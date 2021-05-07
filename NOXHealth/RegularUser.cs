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
        public int gender { get; set; }
        public string profession { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public int sugarLevel { get; set; }
        public int cholesterolLevel { get; set; }
        public int bloodPreassure { get; set; }
        public double BMILevel { get; set; }
        public bool isActive;

        public void setisActive(int s)
        {
            if (s > 3)
            {
                isActive = true;
            }
            else
            {
                isActive = false;
            }
        }

        //public RegularUser(string email, string password, bool loginStatus, DateTime registerDate)
        //{
        //    this.email = email;
        //    this.password = password;
        //    this.loginStatus = loginStatus;
        //    this.registerDate = registerDate;
        //}


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
        public void countBMILevel()
        {
            double BMIvalue = weight / (height * height);

            if (BMIvalue > 25) //obesitas
            {
                BMILevel = 1;
            }
            else if (BMIvalue < 18.5) //kurus
            {
                BMILevel = 5;
            }
            else //ideal
            {
                BMILevel = 3;
            };
        }

        public double countDietValue()
        {
            double resultLevel = 0; // max = 5 ; min = 1.4
            int ageLevel = 0;
            int genderLevel = 0;
            int eatTimeLevel = 0;
            int isActiveLevel = 0;

            //age level
            if (age > 50)
            {
                ageLevel = 1;
            }
            else if (age > 30)
            {
                ageLevel = 2;
            }
            else if (age > 20)
            {
                ageLevel = 4;
            }
            else if (age > 12)
            {
                ageLevel = 7;
            }
            else
            {
                ageLevel = 5;
            }

            //gender level
            switch (gender)
            {
                case 1:
                    genderLevel = 4; break;
                case 2:
                    genderLevel = 3; break;
            }

            //isActiveLevel
            if (isActive)
            {
                isActiveLevel = 5;
            }
            else
            {
                isActiveLevel = 1;
            }

            countBMILevel();
            resultLevel = (ageLevel + genderLevel + eatTimeLevel + BMILevel + isActiveLevel) / 5;

            // Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5},", ageLevel, genderLevel, eatTimeLevel, BMILevel, isActiveLevel, resultLevel);

            return resultLevel;
        }
    }
}
