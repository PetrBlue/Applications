using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizzerie
{
    internal class Pizzeria
    {
        static public List<Pizza> listPizz = new List<Pizza>();
        static public List<Pizza> stulPizz = new List<Pizza>();
        static public int mistVpeci = 3;
        static public bool plnaPec = false; //false - prazdna | true - plna
        static public bool zapalenaPec = false;
        static public int needMouka = 250;
        static public int needSul = 5;
        static public int needVoda = 400;
        static public int needDrozdi = 45;
        static public int kapacitaPizzerie = 5;
        public Pizzeria()
        {

        }
        public static int VratIndex(string ingredience)
        {
            for(int i = 0; i < Skladiste.dostupneIngredience.Count; i++)
            {
                if(Skladiste.dostupneIngredience[i].nazev == ingredience)
                {
                    return i;
                }
            }
            return -1;
        }
        static public void VyrobTesto()
        {
            Console.Clear();
            if (Skladiste.dostupneIngredience[VratIndex("mouka")].mnozstvi > needMouka &&
                Skladiste.dostupneIngredience[VratIndex("sul")].mnozstvi > needSul &&
                Skladiste.dostupneIngredience[VratIndex("voda")].mnozstvi > needVoda &&
                Skladiste.dostupneIngredience[VratIndex("drozdi")].mnozstvi > needDrozdi)
            {
                Skladiste.dostupneIngredience[VratIndex("mouka")].mnozstvi -= needMouka;
                Skladiste.dostupneIngredience[VratIndex("sul")].mnozstvi -= needSul;
                Skladiste.dostupneIngredience[VratIndex("voda")].mnozstvi -= needVoda;
                Skladiste.dostupneIngredience[VratIndex("drozdi")].mnozstvi -= needDrozdi;
                Skladiste.testo++;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Těsto bylo vytvořeno, nyní máš na skladě {Skladiste.testo} těst.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("mouka")].mnozstvi - needMouka) < needMouka)
                {
                    Console.WriteLine($"Máš málo mouky. Chybí ti {needMouka - Skladiste.dostupneIngredience[Pizzeria.VratIndex("mouka")].mnozstvi}g mouky");
                }
                if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("sul")].mnozstvi - needSul) < needSul)
                {
                    Console.WriteLine($"Máš málo soli. Chybí ti {needSul - Skladiste.dostupneIngredience[Pizzeria.VratIndex("sul")].mnozstvi}g soli.");
                }
                if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("voda")].mnozstvi - needVoda) < needVoda)
                {
                    Console.WriteLine($"Máš málo vody. Chybí ti {needVoda - Skladiste.dostupneIngredience[Pizzeria.VratIndex("voda")].mnozstvi}ml vody.");
                }
                if ((Skladiste.dostupneIngredience[Pizzeria.VratIndex("drozdi")].mnozstvi - needDrozdi) < needDrozdi)
                {
                    Console.WriteLine($"Máš málo droždí. Chybí ti {needDrozdi - Skladiste.dostupneIngredience[Pizzeria.VratIndex("drozdi")].mnozstvi}g droždí.");
                }
                Console.WriteLine("\nDoplň chybějící ingredience do skladiště.");
            }
        }
        static public void VlozDoPece(Pizza pizza)
        {
            Console.Clear();
            if(zapalenaPec == true)
            {
                if (mistVpeci > 0)
                {
                    mistVpeci--;
                    pizza.hozenaDoPece = true;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Pizza byla vložena do pece.");
                }
                else
                {
                    plnaPec = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Je plná pec, vyndej nějakou pizzu z pece.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pec není zapálena. Zapalte pec prosím.");
            }
        }
        static public void VyndejZpece(Pizza pizza)
        {
            if(pizza.hozenaDoPece == true)
            {
                Console.Clear();
                pizza.upeceno = true;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Upeceno");
                mistVpeci++;
                plnaPec = false;
                if (stulPizz.Count < kapacitaPizzerie)
                {
                    stulPizz.Add(pizza);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Pizza byla přidána na stůl.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Stůl už je plný pizz. Vyberte si kterou pizzu chcete nahradit:");
                    for (int i = 0; i < stulPizz.Count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{i+1}) {stulPizz[i]}");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Vyber pozici pizzy: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string userInput = Console.ReadLine();
                    while (!Int32.TryParse(userInput, out int number) || int.Parse(userInput) < 1 || int.Parse(userInput) > 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Nezadali jste správné číslo. Zvolte jednu ze zobrazených možností:");
                        for (int i = 0; i < stulPizz.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{i + 1}) {stulPizz[i]}");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Vyber pozici pizzy: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        userInput = Console.ReadLine();
                    }
                    stulPizz.RemoveAt(int.Parse(userInput));
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("V peci není žádná šunková pizza.");
            }
        }
        static public void ZapalPec()
        {
            zapalenaPec = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pec byla zapálena.");
        }
        static public void UhasPec()
        {
            zapalenaPec = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pec byla usehasena.");
        }
        static public void VypisObsahPece()
        {
            Console.WriteLine($"Kapacita pece je {mistVpeci}.\nV peci je: {3-mistVpeci} pizz.");
        }
        static public void Stul()
        {
            foreach (var stul in stulPizz)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{stul}");
            }
        }
    }
}