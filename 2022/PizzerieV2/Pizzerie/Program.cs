using System;
using System.Threading;

namespace Pizzerie
{
    internal class Program
    {
        static public SunkovaPizza sunkovaPizza;
        static public QuatroPizza quatroPizza;
        static public Pizza pizza;
        static public bool prvniSpusteni = false;
        static public List<Pizza> pizzaList = new List<Pizza>();
        //Skladiste skladiste = new Skladiste();
        //Pizzeria pizzeria = new Pizzeria();
        static void Main()
        {
            //Dark Gray = ReadKey; Green = Info Text; Cyan = User Input; Red = Error; Dark Magenta = Answer
            string userInput;
            if(prvniSpusteni == false)
            {
                Skladiste.VygenerujSuroviny();
                prvniSpusteni = true;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This application was made by blue.");
                Thread.Sleep(100);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ahoj, vítej v mé pizzérii.\nZde máš možnosti pro pokračování:\n\t1) Výroba Těsta\n\t2) Výroba Šunkové Pizzy\n\t3) Výroba Quatro Formagi Pizzy\n\t4) Výpis surovin\n\t5) Výpis stolu\n\t6) Nastavení Pece\n\t7) Výpis všech pizz\n\t8) Přidej tisíc surovin do skladu\n\t9) Ukonči program\n\nTvá volba: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out int number) || int.Parse(userInput) < 1 || int.Parse(userInput) > 9)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ahoj, vítej v mé pizzérii.\nZde máš možnosti pro pokračování:\n\t1) Výroba Těsta\n\t2) Výroba Šunkové Pizzy\n\t3) Výroba Quatro Formagi Pizzy\n\t4) Výpis surovin\n\t5) Výpis stolu\n\t6) Nastavení Pece\n\t7) Výpis všech pizz\n\t8) Přidej tisíc surovin do skladu\n\t9) Ukonči program\n\nTvá volba: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();
                Console.Clear();
            }
            switch (userInput)
            {
                case "1":
                    Pizzeria.VyrobTesto();
                    Wait();
                    Main();
                    break;
                case "2":
                    VyrobaSunkovePizzy();
                    Wait();
                    Main();
                    break;
                case "3":
                    VyrobaQuatroPizzy();
                    Wait();
                    Main();
                    break;
                case "4":
                    Skladiste.VypisSuroviny();
                    Wait();
                    Main();
                    break;
                case "5":
                    Pizzeria.Stul();
                    Wait();
                    Main();
                    break;
                case "6":
                    NastaveniPece();
                    Wait();
                    Main();
                    break;
                case "7":
                    VypisVsechnyPizzy();
                    Wait();
                    Main();
                    break;
                case "8":
                    Skladiste.PridejSuroviny(1000);
                    Wait();
                    Main();
                    break;
                case "9":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nevím jak jsi se sem dostal, prosím napiš mi tvé kroky.");
                    Wait();
                    Main(); 
                    break;
            }
        }
        static public void VyrobaSunkovePizzy()
        {
            Console.Clear();    
            string userInput;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej u výroby šunkové pizzy.\nCo si přejete udělat se svojí pizzou?\n\t1) Vyrobit novou pizzu\n\t2) Upéct pizzu v peci\n\t3) Vytáhnout pizzu z pece\n\t4) Jít do menu\n\nTvá volba: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out int number) || int.Parse(userInput) < 1 || int.Parse(userInput) > 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Vítej u výroby šunkové pizzy.\nCo si přejete udělat se svojí pizzou?\n\t1) Vyrobit novou pizzu\n\t2) Upéct pizzu v peci\n\t3) Vytáhnout pizzu z pece\n\t4) Jít do menu\n\nTvá volba: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();
                Console.Clear();
            }
            switch (userInput)
            {
                case "1":
                    sunkovaPizza = new SunkovaPizza();
                    pizzaList.Add(sunkovaPizza);
                    sunkovaPizza.VyrobPizzu(200, 100, 200, 200);
                    Wait();
                    VyrobaSunkovePizzy();
                    break;
                case "2":
                    Pizzeria.VlozDoPece(pizza: sunkovaPizza);
                    Wait();
                    VyrobaSunkovePizzy();
                    break;
                case "3":
                    Pizzeria.VyndejZpece(pizza: sunkovaPizza);
                    Wait();
                    VyrobaSunkovePizzy();
                    break;
                case "4":
                    Main();
                    break;
                default:
                    break;
            }
        }
        static public void VyrobaQuatroPizzy()
        {
            Console.Clear();
            string userInput;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej u výroby quatro pizzy.\nCo si přejete udělat se svojí pizzou?\n\t1) Vyrobit novou pizzu\n\t2) Upéct pizzu v peci\n\t3) Vytáhnout pizzu z pece\n\t4) Jít do menu\n\nTvá volba: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out int number) || int.Parse(userInput) < 1 || int.Parse(userInput) > 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Vítej u výroby quatro pizzy.\nCo si přejete udělat se svojí pizzou?\n\t1) Vyrobit novou pizzu\n\t2) Upéct pizzu v peci\n\t3) Vytáhnout pizzu z pece\n\t4) Jít do menu\n\nTvá volba: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();
                Console.Clear();
            };
            switch (userInput)
            {
                case "1":
                    quatroPizza = new QuatroPizza();
                    pizzaList.Add(quatroPizza);
                    quatroPizza.VyrobPizzu(200, 100, 200, 150, 100, 50);
                    Wait();
                    VyrobaQuatroPizzy();
                    break;
                case "2":
                    Pizzeria.VlozDoPece(pizza: quatroPizza);
                    Wait();
                    VyrobaQuatroPizzy();
                    break;
                case "3":
                    Pizzeria.VyndejZpece(pizza: quatroPizza);
                    Wait();
                    VyrobaQuatroPizzy();
                    break;
                case "4":
                    Main();
                    break;
                default:
                    break;
            }
        }
        static public void VypisVsechnyPizzy()
        {
            foreach(var tempPizza in pizzaList)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{tempPizza}");
            }
        }
        static public void NastaveniPece()
        {
            Console.Clear();
            string userInput;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej v nastavení pece.\nCo si přejete udělat se svojí pecí?\n\t1) Zapálit pec\n\t2) Uhasnout pec\n\t3) Vypsat kapacitu pece\n\t4) Jít do menu\n\nTvá volba: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out int number) || int.Parse(userInput) < 1 || int.Parse(userInput) > 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Vítej u výroby šunkové pizzy.\nCo si přejete udělat se svojí pizzou?\n\t1) Vyrobit novou pizzu\n\t2) Upéct pizzu v peci\n\t3) Vypsat pizzy v peci\n\t4) Jít do menu\n\nTvá volba: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();
                Console.Clear();
            }
            switch (userInput)
            {
                case "1":
                    Pizzeria.ZapalPec();
                    Wait();
                    NastaveniPece();
                    break;
                case "2":
                    Pizzeria.UhasPec();
                    Wait();
                    NastaveniPece();
                    break;
                case "3":
                    Pizzeria.VypisObsahPece();
                    Wait();
                    NastaveniPece();
                    break;
                case "4":
                    Main();
                    break;
                default:
                    break;
            }
        }
        static public void Wait()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}