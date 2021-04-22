using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class Exercise : Recommendation
    {
        public int duration { get; set; }
        public int difficulty { get; set; }
        public int repetition { get; set; }

        public Exercise(DateTime time)
        {
            this.time = time;
        }

        public override void showRecommendation()
        {

        }

    }

    
}
