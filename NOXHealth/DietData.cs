using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class DietData
    {
        public string name { get; set; }
        public int carbo { get; set; }
        public int protein { get; set; }
        public int vitamin { get; set; }
        public int fat { get; set; }

        public DietData(string name, int carbo, int protein, int vitamin, int fat)
        {
            this.name = name;
            this.carbo = carbo;
            this.protein = protein;
            this.vitamin = vitamin;
            this.fat = fat;
        }
    }

}
