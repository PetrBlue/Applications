using System;

namespace Kalkulaaacka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hahaha = true;

            if (hahaha == true)
            {
            operace:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napiš hodnotu a:");
                Console.ForegroundColor = ConsoleColor.White;
                int a = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napiš hodnotu b:");
                Console.ForegroundColor = ConsoleColor.White;
                int b = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hodnoty jsou " + a + " a " + b);
                Console.WriteLine("Co za operaci chceš dělat: \r\n 1) Plus \r\n 2) Mínus \r\n 3) Krát \r\n 4) Děleno \r\n 5) Mocnina");
                Console.ForegroundColor = ConsoleColor.White;
                int operace = int.Parse(Console.ReadLine());
                if (operace == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a + b;
                    Console.WriteLine("Výsledek je " + vysledek);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n Nový příklad? \r\n 1) Ano \r\n 2) Ne");
                    Console.ForegroundColor = ConsoleColor.White;
                    int again = int.Parse(Console.ReadLine());
                    if (again == 1)
                    {
                        goto operace;
                    }
                    if (again == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kkte netrol");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (operace == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a - b;
                    Console.WriteLine("Výsledek je " + vysledek);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n Nový příklad? \r\n 1) Ano \r\n 2) Ne");
                    Console.ForegroundColor = ConsoleColor.White;
                    int again = int.Parse(Console.ReadLine());
                    if (again == 1)
                    {
                        goto operace;
                    }
                    if (again == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kkte netrol");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (operace == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a * b;
                    Console.WriteLine("Výsledek je " + vysledek);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n Nový příklad? \r\n 1) Ano \r\n 2) Ne");
                    Console.ForegroundColor = ConsoleColor.White;
                    int again = int.Parse(Console.ReadLine());
                    if (again == 1)
                    {
                        goto operace;
                    }
                    if (again == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kkte netrol");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (operace == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a / b;
                    Console.WriteLine("Výsledek je " + vysledek);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n Nový příklad? \r\n 1) Ano \r\n 2) Ne");
                    Console.ForegroundColor = ConsoleColor.White;
                    int again = int.Parse(Console.ReadLine());
                    if (again == 1)
                    {
                        goto operace;
                    }
                    if (again == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kkte netrol");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (operace == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    int vysledek = a * a;
                    int vysledek2 = b * b;
                    Console.WriteLine("Výsledek je " + vysledek + " a " + vysledek2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n Nový příklad? \r\n 1) Ano \r\n 2) Ne");
                    Console.ForegroundColor = ConsoleColor.White;
                    int again = int.Parse(Console.ReadLine());
                    if (again == 1)
                    {
                        goto operace;
                    }
                    if (again == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kkte netrol");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kkte netrol");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
