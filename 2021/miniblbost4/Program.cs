using System;

namespace miniblbost4
{
    class Program
    {
        static void Main(string[] args)
        {

            int hracZivoty = 100;
            int hracDMG = 10;


            int priseraZivoty = 20;
            int priseraDMG = 20;


            bool hra = true;
            int volba = 0;

            while (hra == true)
            {
                if (hracZivoty <= 0)
                {
                    hra = false;
                }
                if (priseraZivoty <= 0)
                {
                    Console.WriteLine("ZABIL SI PŘÍŠERU!");
                    Console.WriteLine("here take some healling potion");
                    Console.WriteLine("New creature appeared!");
                    priseraZivoty = 20;
                }

                while (hracZivoty > 0 && priseraZivoty > 0)
                {
                    Console.WriteLine("Hráč \t  HP: " + hracZivoty + " DMG: " + hracDMG);
                    Console.WriteLine("Příšera \t HP: " + priseraZivoty + " DMG: " + priseraDMG);
                    Console.WriteLine("\n\t1) útok");
                    volba = Int32.Parse(Console.ReadLine());
                    if (volba == 1)
                    {
                        priseraZivoty -= hracDMG;
                    }
                    else
                    {
                        Console.WriteLine("Špatná volba");
                    }
                }
            }
        }
    }
}
