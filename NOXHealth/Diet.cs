using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class Diet : Recommendation
    {

        public override void showRecommendation()
        {
            RegularUser count = new RegularUser();
            double resultLevel = count.countDietValue();

            DietList DietName = new DietList();

            if (resultLevel >= 3.6) //High
            {
                Console.WriteLine("Rekomendasi Makanan: ");
                printResult(DietName.DietHighCalories);

            }
            else if (resultLevel < 3.6 && resultLevel >= 3) //Medium
            {
                Console.WriteLine("Rekomendasi Makanan: ");
                printResult(DietName.DietMedCalories);
            }
            else if (resultLevel < 3) //Low
            {
                Console.WriteLine("Rekomendasi Makanan: ");
                printResult(DietName.DietLowCalories);
            }

        }
        public void printResult(List<DietData> DietList)
        {
            int counter = 1;

            foreach (DietData food in DietList)
            {
                Console.WriteLine("{0}. " + food.name, counter);
                counter++;
            }
        }
        public void showNutritions()
        {

        }
    }
}
