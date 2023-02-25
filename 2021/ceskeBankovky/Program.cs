using System;

namespace ceskeBankovky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš číslo");
            Console.ForegroundColor = ConsoleColor.White;
            int cislo = int.Parse(Console.ReadLine());
            int[] cisla = new int[12];
            int[] bankovky = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000 };

            for (int i = 11; i > -1; i--)
            {
                cisla[i] = cislo / bankovky[i];
                cislo = cislo - cisla[i] * bankovky[i];
                Console.WriteLine(cisla[i] + "x " + bankovky[i]);
            }
        }
    }
}
