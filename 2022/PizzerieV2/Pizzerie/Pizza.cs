using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizzerie
{
    internal class Pizza
    {
        public bool upeceno = false;
        public bool hozenaDoPece = false;
        static public int needProtlak = 200;
        static public int needKoreni = 15;
        static public int needSunka = 100;
        static public int needGouda = 200;
        static public int needEidam = 150;
        static public int needNiva = 100;
        static public int needParmazan = 50;
        static public int needSmetana = 200;
        public Pizza()
        {

        }
        public virtual void VyrobPizzu(int protlak, int koreni, int gouda, params int[] zbytekIngredienci)
        {
            if(Skladiste.testo > 0)
            {
                    if (Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi > protlak &&
                        Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi > koreni &&
                        Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi > gouda)
                    {
                    Console.WriteLine("Protlak: " + Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi + "\nKoreni: " + Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi + "\nGouda: " + Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi);
                        Skladiste.dostupneIngredience[Pizzeria.VratIndex("protlak")].mnozstvi -= protlak;
                        Skladiste.dostupneIngredience[Pizzeria.VratIndex("koreni")].mnozstvi -= koreni;
                        Skladiste.dostupneIngredience[Pizzeria.VratIndex("gouda")].mnozstvi -= gouda;
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
