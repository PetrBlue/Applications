using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbranClass
{
    internal class Zbran
    {
        protected int zasobnik, pocetNaboju, pocetMaximalnichNaboju;
        public int Zasobnik {get{return zasobnik;} private set{}}
        public Zbran()
        {
            zasobnik = 5;
            pocetNaboju = 0;
            pocetMaximalnichNaboju = 0;
        }
        public void VypisPocetNaboju()
        {
            Console.WriteLine(pocetNaboju);
            
        }
        void NastavPocetNaboju(int pocet)
        {
            pocetNaboju = pocet;
        }
    }
}
