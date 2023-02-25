using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzerie
{
    internal class Ingredience
    {
        public string nazev;
        public int mnozstvi;
        public DateTime vyrobniTrvanlivost;
        public DateTime konecniTrvanlivost;
        //List<Ingredience> dostupneIngredience = new List<Ingredience>();
        public Ingredience ( string nazev, int mnozstvi/*, DateTime trvanlivost*/)
        {
            this.nazev = nazev;
            this.mnozstvi = mnozstvi;
            konecniTrvanlivost = vyrobniTrvanlivost.AddDays(7);
            //dostupneIngredience.Add(this);
        }
    }
}
