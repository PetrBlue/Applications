using System;

namespace Hospudka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pivo = 35;
            int penize = 0;
            int muzi;
            int zeny;

            for (int i = 0; i < 180; i++)
            {
                int hosti = rnd.Next(18, 52);
                muzi = (hosti + 1) / 2;
                zeny = muzi;
                int denniPrijem = (muzi * pivo * 2) + (zeny * pivo);
                penize += denniPrijem;

                if (i % 30 == 0)
                {
                    penize -= 25000;
                }
                if (i % 30 == 1)
                {
                    penize += denniPrijem / 35 * 30 * 2;
                    penize -= 7500;
                }
            }
            int pokuta = rnd.Next(0, 101);
            if (pokuta => 35)
            {
                penize -= 100000;
            }
            Console.WriteLine(penize + "Kč");
        }
    }
}
