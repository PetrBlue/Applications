using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizzerie
{
    internal class QuatroPizza : Pizza
    {
        public QuatroPizza()
        {

        }
        public override void VyrobPizzu(int protlak, int koreni, int gouda, params int[] zbytekIngredienci)
        {
            if (Skladiste.testo > 0)
            {
                if (Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi > protlak &&
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi > koreni &&
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi > gouda &&
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("eidam")].mnozstvi > zbytekIngredienci[0] && //eidam
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("niva")].mnozstvi > zbytekIngredienci[1] && //niva
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("parmazan")].mnozstvi > zbytekIngredienci[2]) //parmazan
                {
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi -= protlak;
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi -= koreni;
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi -= gouda;
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("eidam")].mnozstvi -= zbytekIngredienci[0]; //eidam
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("niva")].mnozstvi -= zbytekIngredienci[1]; //niva
                    Skladiste.dostupneIngredience[Pizzeria.VratIndex("parmazan")].mnozstvi -= zbytekIngredienci[2]; //parmazan
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Šunková pizza je hotová, připravena přímo do pece.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi - protlak) < needProtlak)
                    {
                        Console.WriteLine($"Máš málo protlaku. Chybí ti {protlak - Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi}ml protlaku.");
                    }
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi - koreni) < needKoreni)
                    {
                        Console.WriteLine($"Máš málo koření. Chybí ti {koreni - Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi}g koření.");
                    }
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi - gouda) < needGouda)
                    {
                        Console.WriteLine($"Máš málo goudy. Chybí ti {gouda - Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi}g goudy.");
                    }
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("eidam")].mnozstvi - zbytekIngredienci[0]) < needEidam)
                    {
                        Console.WriteLine($"Máš málo eidamu. Chybí ti {zbytekIngredienci[0] - Skladiste.dostupneIngredience[Pizzeria.VratIndex("eidam")].mnozstvi}g eidamu.");
                    }
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("niva")].mnozstvi - zbytekIngredienci[1]) < needNiva)
                    {
                        Console.WriteLine($"Máš málo nivy. Chybí ti {zbytekIngredienci[1] - Skladiste.dostupneIngredience[Pizzeria.VratIndex("niva")].mnozstvi}g nivy.");
                    }
                    if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("parmazan")].mnozstvi - zbytekIngredienci[2]) < needParmazan)
                    {
                        Console.WriteLine($"Máš málo parmazánu. Chybí ti {zbytekIngredienci[2] - Skladiste.dostupneIngredience[Pizzeria.VratIndex("parmazan")].mnozstvi}g parmazánu.");
                    }
                    Console.WriteLine("\nDoplň chybějící ingredience do skladiště.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Není vyrobené žádné dostupné těsto! Prosím vyrobte další těsto pro vytvoření šunkové pizzy.");
            }
        }
    }
}
