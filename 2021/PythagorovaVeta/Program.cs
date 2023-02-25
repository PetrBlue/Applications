using System;

namespace PythagorovaVeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Zadej hodnotu a:");
            Console.ForegroundColor = ConsoleColor.White;
            int a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zadej hodnotu b:");
            Console.ForegroundColor = ConsoleColor.White;
            int b = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš co chceš s číslem dělat: \r\n 1) Spočítat odvěsnu \r\n 2) Spočítat příponu");
            Console.ForegroundColor = ConsoleColor.White;
            int cochces = int.Parse(Console.ReadLine());
            if (cochces == 1)
            {
                a = a * a;
                b = b * b;
                if(a <= b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = b - a;
                    double v = Math.Sqrt(vysledek);
                    Console.WriteLine("Výsledek je " + v + "cm");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                if (a >= b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a - b;
                    double v = Math.Sqrt(vysledek);
                    Console.WriteLine("Výsledek je " + v + "cm");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            if (cochces == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                a = a * a;
                b = b * b;
                if (a <= b)
                {
                    int vysledek = b + a;
                    double v = Math.Sqrt(vysledek);
                    Console.WriteLine("Výsledek je " + v + "cm");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jsi debil");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
