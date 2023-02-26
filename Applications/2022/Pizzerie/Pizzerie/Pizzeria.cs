using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzerie
{
    internal class Pizzeria
    {
        public int mistVpeci = 2;
        public bool pec = false; //false - prazdna | true - plna
        public int testo = 0;
        public int needMouka = 250;
        public int needSul = 5;
        public int needVoda = 400;
        public int needDrozdi = 45;
        public Pizzeria()
        {

        }
        public int VratIndex(string ingredience)
        {
            for(int i = 0; i < Skladiste.dostupneIngredience.Count; i++)
            {
                if(Skladiste.dostupneIngredience[i].nazev == ingredience)
                {
                    return i;
                }
            }
            /*foreach(var item in Skladiste.dostupneIngredience)
            {
                if(item.nazev == ingredience)
                {
                    return Sklad
                }
            }*/
            return -1;
        }
        public void VyrobTesto()
        {
            //KontrolaIngredienci();
            if (Skladiste.dostupneIngredience[VratIndex("mouka")].mnozstvi > needMouka &&
                Skladiste.dostupneIngredience[VratIndex("sul")].mnozstvi > needSul &&
                Skladiste.dostupneIngredience[VratIndex("voda")].mnozstvi > needVoda &&
                Skladiste.dostupneIngredience[VratIndex("drozdi")].mnozstvi > needDrozdi)
            {
                Skladiste.dostupneIngredience[VratIndex("mouka")].mnozstvi -= needMouka;
                Skladiste.dostupneIngredience[VratIndex("sul")].mnozstvi -= needSul;
                Skladiste.dostupneIngredience[VratIndex("voda")].mnozstvi -= needVoda;
                Skladiste.dostupneIngredience[VratIndex("drozdi")].mnozstvi -= needDrozdi;
                Console.WriteLine("Testo bylo vytvoreno, u r op af also u r a fucking god");
                testo++;
            }
            else
            {
                Console.WriteLine("Chybi ti neco debile.");
            }
        }
        /*public void KontrolaIngredienci(string[] x)
        {
            string chybejiciIngredience = "";
        }*/
        public void VlozTestoDoPece(Pizza pizza)
        {
            /*
            if(testo > 0 && mistVpeci > 0)
            {

            }*/
        }
        //TODO pizzu do pece
        public void VyndejZpece(Pizza pizza)
        {

        }

    }
}
