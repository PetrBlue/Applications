using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Stul
    {
        Random rnd = new Random();
        public List<Lidi> lidiUstolu;
        public int kapacitaLidi = 4;
        internal string nazev { get; private set; } = "qwertyuiopasdfghjklzxcvbnm";
        public string name { get; private set; }
        public Stul(int kapacita)
        {
            nazev = PojmenujStul();
            //nazev = nazev.ToCharArray()[rnd.Next(0, nazev.Length)].ToString().ToUpper();
            lidiUstolu = new List<Lidi>();
            kapacitaLidi = kapacita;
        }
        public void UsadCloveka(Lidi clovek)
        {
            if(kapacitaLidi > 0)
            {
                lidiUstolu.Add(clovek);
                kapacitaLidi--;
            }
        }
        public void VyhozeniCloveka(Lidi clovek)
        {
            if(lidiUstolu.Count > 0 && lidiUstolu.Contains(clovek))
            {
                lidiUstolu.Remove(clovek);
                kapacitaLidi++;
            }
        }
        public string PojmenujStul()
        {
            string pismenko = nazev.ToCharArray()[rnd.Next(0, nazev.Length)].ToString().ToUpper();
            foreach (Stul s in Restaurace.seznamStolu)
            {
                while (pismenko == s.nazev)
                {
                    nazev.ToCharArray()[rnd.Next(0, nazev.Length)].ToString().ToUpper();
                }
            }
            return pismenko;
        }
    }
}
