using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    public abstract class Recommendation
    {
        public DateTime time { get; set; }

        public abstract void showRecommendation();

    }
}
