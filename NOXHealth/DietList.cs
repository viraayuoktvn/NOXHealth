using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class DietList
    {
        public DietList()
        {
            CreateHighCalories();
            CreateMedCalories();
            CreateLowCalories();
        }
        public List<DietData> DietLowCalories = new List<DietData>();
        public List<DietData> DietMedCalories = new List<DietData>();
        public List<DietData> DietHighCalories = new List<DietData>();
        public List<String> CreateLowCalories()
        {
            DietLowCalories.Add(new DietData("Karedok", 0, 0, 0, 0));
            DietLowCalories.Add(new DietData("Pepes Ikan", 0, 0, 0, 0));
            DietLowCalories.Add(new DietData("Omelet Sayur", 0, 0, 0, 0));
            DietLowCalories.Add(new DietData("Nasi Merah", 0, 0, 0, 0));
            DietLowCalories.Add(new DietData("Pecel", 0, 0, 0, 0));

            return null;
        }
        public List<String> CreateMedCalories()
        {
            DietMedCalories.Add(new DietData("Mie Ayam", 0, 0, 0, 0));
            DietMedCalories.Add(new DietData("Bakso", 0, 0, 0, 0));
            DietMedCalories.Add(new DietData("Ketoprak", 0, 0, 0, 0));
            DietMedCalories.Add(new DietData("Ayam Bakar", 0, 0, 0, 0));
            DietMedCalories.Add(new DietData("Gudeg", 0, 0, 0, 0));

            return null;
        }
        public List<String> CreateHighCalories()
        {
            DietHighCalories.Add(new DietData("Nasi Padang", 0, 0, 0, 0));
            DietHighCalories.Add(new DietData("Lontong Sayur", 0, 0, 0, 0));
            DietHighCalories.Add(new DietData("Nasi Uduk", 0, 0, 0, 0));
            DietHighCalories.Add(new DietData("Nasi Goreng", 0, 0, 0, 0));
            DietHighCalories.Add(new DietData("Ramen", 0, 0, 0, 0));

            return null;
        }
        


    }
}
