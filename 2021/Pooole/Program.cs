using System;

namespace Pooole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš velikost pole :)");
            Console.ForegroundColor = ConsoleColor.White;
            int velikost = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš číslo indexu {0}-{0} :)", velikost-1, velikost+1);
            Console.ForegroundColor = ConsoleColor.White;
            int index = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš číslo :)");
            Console.ForegroundColor = ConsoleColor.White;
            int cislo = int.Parse(Console.ReadLine());
            int[] jmeno = new int[velikost];
            jmeno[index] = cislo;
            for (int i = 0; i < jmeno.Length; i++)
            {
                Console.WriteLine(jmeno[i]);
            }
        }
    }
}
