using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class Sleep : Recommendation
    {
        public int duration { get; set; }

        public Sleep(DateTime time)
        {
            this.time = time;
        }

        public override void showRecommendation()
        {

        }
    }
}
