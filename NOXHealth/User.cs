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
        public string username { get; set; }
        public string password { get; set; }
        public bool loginStatus { get; set; }
        public DateTime registerDate { get; set; }

        public abstract void register();
        public abstract void login();

        public void chooseAim()
        {
            //Console.WriteLine("What goals do you want to achieve?");
            //Console.WriteLine("1. Keep healthy");
            //Console.WriteLine("2. Increase weight");
            //Console.WriteLine("3. Decrease weight");

            //int goal = Convert.ToInt16(Console.ReadLine());

            //if (goal == 1)
            //{
            //    Diet diet = new Diet();
            //    diet.showRecommendation();

            //    Exercise exercise = new Exercise();
            //    exercise.showRecommendation();

            //    Sleep sleep = new Sleep();
            //    sleep.showRecommendation();
            //}
            //else if (goal == 2)
            //{
            //    Diet diet = new Diet();
            //    diet.showRecommendation();
            //}
            //else if (goal == 3)
            //{
            //    Diet diet = new Diet();
            //    diet.showRecommendation();
            //}
            //else
            //{
            //    Console.WriteLine("Your choice is not in the option! Please choose again.");
            //    chooseAim();
            //}
        }
    }
}
