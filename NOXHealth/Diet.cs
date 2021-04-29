using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class Diet : Recommendation
    {
        public int carbo { get; set; }
        public int protein { get; set; }
        public int vitamin { get; set; }
        public int fat { get; set; }

        public Diet(DateTime time)
        {
            this.time = time;
        }

        public Diet()
        {
        }

        public override void showRecommendation()
        {

        }

        public void showNutritions()
        {

        }
    }
}
