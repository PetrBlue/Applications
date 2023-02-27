using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoPujcovna
{
    internal class autoPujc
    {
        List<Auto> listAuticek = new List<Auto>();
        protected string nazev, misto;
        public autoPujc(string nazev, string misto, List<Auto> auticko)
        {
            this.nazev = nazev;
            this.misto = misto;
            this.listAuticek = auticko;
        }
        public void autoPujcovna()
        {/*
            listAuticek1[0] = new Auto(4, "Ne", "Ano");
            listAuticek1[1] = new Auto(4, "Ano", "Ne");
            listAuticek2[0] = new Auto(4, "Ne", "Ano");
            listAuticek2[1] = new Auto(4, "Ano", "Ne");*/
        }

        public void VypisAutopujcoven()
        {
            Console.WriteLine($"Název: {nazev}, Místo: {misto}");
        }
        public void VypisAuta()
        {
            for(int i = 0; i < listAuticek.Count; i++)
            {
                Console.WriteLine($"Značka: {listAuticek[i].znacka}, Model: {listAuticek[i].model}, Počet Kol: {listAuticek[i].pocetKol}");
            }
        }
    }
}
