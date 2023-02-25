using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoly
{
    public class Skola
    {
        public int zaci;
        public string barvaSkoly;
        public string weboveStranky;
        public Skola(int zaci, string barvaSkoly, string weboveStranky) {
            this.zaci = zaci;
            this.barvaSkoly = barvaSkoly;
            this.weboveStranky = weboveStranky;
        }
    }
}
