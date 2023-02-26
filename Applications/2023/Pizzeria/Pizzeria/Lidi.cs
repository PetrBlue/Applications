using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Lidi
    {
        public string name { get; private set; }
        public int cash { get; private set; }
        List<Alergeny> alergeny;
        Random rnd = new Random();
        internal static string[] jmena = { "Karel", "Pavel", "Karolína", "Hanka", "Petr", "David", "Chamber", "Dejw7n", "Davyd" };
        public Lidi(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
            alergeny = new List<Alergeny>();
            //VyberNahodneAlergeny();
            if (SanceNaAlergen())
            {
                VyberNahodneAlergeny(rnd.Next(1, VratListAlergenu().Count));
            }
        }
        public List<Alergeny> VratListAlergenu()
        {
            return Enum.GetValues(typeof(Alergeny)).Cast<Alergeny>().ToList();
        }
        public void VyberNahodneAlergeny(int pocet)
        {
            Random rnd = new Random();
            //if(pocet > 0 && pocet <= VratListAlergeny().Count)
            if(pocet > VratListAlergenu().Count)
            {
                pocet = VratListAlergenu().Count;
            }
            while (pocet > 0)
            {
                Alergeny temp = new Alergeny();
                temp = VratListAlergenu()[rnd.Next(0, VratListAlergenu().Count)];
                if (!alergeny.Contains(temp))
                {
                    this.alergeny.Add(temp);
                    pocet--;
                }
                //this.alergeny.Add(VratListAlergeny()[rnd.Next(0, VratListAlergeny().Count)]);
            }
        }
        public void OdeberPenize(int pocet)
        {
            cash -= pocet;
        }
        public bool SanceNaAlergen()
        {
            Random rnd = new Random();
            if(rnd.Next(0, 2) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
