using System;

namespace CislaPodleKorun
{
    class Program
    {
        static void Main(string[] args)
        {
        zapis:
            int jednotky = 0;
            int desítky = 0;
            int stovky = 0;
            int tisíce = 0;
            int desetitisíce = 0;
            int statisíce = 0;
            int miliony = 0;
            int desetimiliony = 0;
            int stamiliony = 0;
            int miliardy = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš číslo do 1000000000Kč");
            Console.ForegroundColor = ConsoleColor.White;
            int koruny = int.Parse(Console.ReadLine());
            if(koruny > 1000000000)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Zadal jsi špatné číslo");
                Console.ForegroundColor = ConsoleColor.White;
                goto zapis;
            }
                miliardy = koruny / 1000000000;
                koruny = koruny - miliardy * 1000000000;
                stamiliony = koruny / 100000000;
                koruny = koruny - stamiliony * 100000000;
                desetimiliony = koruny / 10000000;
                koruny = koruny - desetimiliony * 10000000;
                miliony = koruny / 1000000;
                koruny = koruny - miliony * 1000000;
                statisíce = koruny / 100000;
                koruny = koruny - statisíce * 100000;
                desetitisíce = koruny / 10000;
                koruny = koruny - desetitisíce * 10000;
                tisíce = koruny / 1000;
                koruny = koruny - tisíce * 1000;
                stovky = koruny / 100;
                koruny = koruny - stovky * 100;
                desítky = koruny / 10;
                koruny = koruny - desítky * 10;
                jednotky = koruny / 1;
                koruny = koruny - jednotky * 1;

            /* jednotky = koruny / 1;
             desítky = koruny / 10;
             stovky = koruny / 100;
             tisíce = koruny / 1000;
             desetitisíce = koruny / 10000; */

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Číslo má " + miliardy + " Miliard.");
            Console.WriteLine("Číslo má " + stamiliony + " Stamilionů.");
            Console.WriteLine("Číslo má " + desetimiliony + " Desetimilionů.");
            Console.WriteLine("Číslo má " + miliony + " Milionů.");
            Console.WriteLine("Číslo má " + statisíce + " Statisíců.");
            Console.WriteLine("Číslo má " + desetitisíce + " Desetitisíců.");
            Console.WriteLine("Číslo má " + tisíce + " Tisíců.");
            Console.WriteLine("Číslo má " + stovky + " Stovek.");
            Console.WriteLine("Číslo má " + desítky + " Desítek.");
            Console.WriteLine("Číslo má " + jednotky + " Jednotek.");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
