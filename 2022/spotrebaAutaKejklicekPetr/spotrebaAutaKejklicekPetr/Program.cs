using System;

namespace spotrebaAutaKejklicekPetr
{
    class Program
    {
        public static double vzdalenost;
        public static double vzdalenostZaLitr = 100/9.3; //https://www.google.com/search?client=opera-gx&q=normal+usage+per+liter+to+drive+a+normal+car&sourceid=opera&ie=UTF-8&oe=UTF-8
        public static double stylJizdy;
        public static double ecoJizda = 1;
        public static double normalniJizda = 1.3;
        public static double sportovniJizda = 1.7;
        public static double cena = 0;
        public static double litry = 0;
        public static double cenaLitru = 37.5;
        public static string stylJizdyVypis = "";

        static void Main(string[] args)
        {
            Uvod();
            Zaver();
        }
        static void Uvod()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítám tě v programu na výpočet ceny na vzdálenost. Prosím zadejte Hodnotu.");
            Console.Write("Vzdálenost: ");
            Console.ForegroundColor = ConsoleColor.White;
            vzdalenost = Int32.Parse(Console.ReadLine());
        loop:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nJaký styl jízdy byste chtěl?\n 1) Eco\n 2) Normální\n 3) Sportovní\nStyl: ");
            Console.ForegroundColor = ConsoleColor.White;
            stylJizdy = Int32.Parse(Console.ReadLine());
            if (stylJizdy > 3 && stylJizdy < 1)
            {
                goto loop;
            }
            litry = vzdalenost / vzdalenostZaLitr;
            switch (stylJizdy)
            {
                case 1:
                    vypocetCeny(ecoJizda);
                    stylJizdyVypis = "Eco Jízda";
                    break;
                case 2:
                    vypocetCeny(normalniJizda);
                    stylJizdyVypis = "Normální Jízda";
                    break;
                case 3:
                    vypocetCeny(sportovniJizda);
                    stylJizdyVypis = "Sportovní Jízda";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Neplatný styl jízdy.");
                    goto loop;
            }
        }
        static double vypocetCeny(double x)
        {
            cena += litry * cenaLitru * x;
            return cena;
        }
        static void Zaver()
        {
            vzdalenost *= 100;
            vzdalenost = Math.Round(vzdalenost);
            vzdalenost /= 100;
            litry *= 100;
            litry = Math.Round(litry);
            litry /= 100;
            cena *= 100;
            cena = Math.Round(cena);
            cena /= 100;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nVzdálenost: {vzdalenost}\nZvolený styl jízdy: {stylJizdyVypis}\nCena za litr: {cenaLitru}Kč\nSpotřebované litry: {litry}\n-----------------\nFinální cena: {cena}Kč");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /*
        static double zmenaNaDveDesetinneCifry(double x)
        {
            x *= 100;
            x = Math.Round(x);
            x /= 100;
            return x;
        }*/
    }
}
