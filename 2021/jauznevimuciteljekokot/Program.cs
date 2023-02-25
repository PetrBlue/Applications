using System;

namespace jauznevimuciteljekokot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            rnd.
            int[] poleCisel = { 1, 2, 3, 4, 5, 6 };
            int[] poleCisel2 = new int[6];
            for (int i = 0; i < poleCisel2.Length; i++)
            {
                poleCisel2[i] = i;
            }   
            Console.WriteLine("Zadej mi hodnotu");
            poleCisel2[0] = int.Parse(Console.ReadLine());
            Console.WriteLine(poleCisel[0]);

        }
    }
}
