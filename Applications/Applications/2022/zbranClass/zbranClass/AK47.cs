using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbranClass
{
    internal class AK47 : Zbran
    { 
        public AK47(){
            pocetMaximalnichNaboju = 30;
            pocetNaboju = pocetMaximalnichNaboju;
        }
    }
}
