using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizzerie
{
    internal class Ingredience
    {
        public string nazev;
        public int mnozstvi;
        public DateTime vyrobniTrvanlivost = DateTime.Today;
        public DateTime konecniTrvanlivost;
        public Ingredience ( string nazev, int mnozstvi)
        {
            this.nazev = nazev;
            this.mnozstvi = mnozstvi;
            konecniTrvanlivost = vyrobniTrvanlivost.AddDays(7);
        }
    }
}
