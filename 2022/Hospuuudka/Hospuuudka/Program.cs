using System;

namespace Hospuuudka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pivo = 35;
            double penize = 0;
            int muzi;
            int zeny;
            double lidi = 1;
            double cenaVystavby = 100000;
            
            for(int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 365; i++)
                {
                    double temp = 51 * lidi + 1;
                    int lidiRandomMax = Convert.ToInt32(temp);
                    int hosti = rnd.Next(18  , lidiRandomMax);


                    if (i % 30 == 0)
                {
                    penize -= 25000;
                }
                if (i % 30 == 1)
                {
                    penize += hosti / 35 * 30 * 2;
                    penize -= 7500;
                }
                if(i % 14 == 0)
                {
                    penize += 129 * hosti;
                    for(int e = 0; e < hosti; e++)
                    {
                        penize -= rnd.Next(49, 80);
                        goto konecDne;
                    }
                }

                muzi = (hosti + 1) / 2;
                zeny = muzi;
                int denniPrijem = (muzi * pivo * 2) + (zeny * pivo);
                penize += denniPrijem;

                double piva = 0;
                double dostatekPiva = 200;

                for (int g = 0; g < muzi; g++)
                {
                    double temp2 = rnd.Next(2, 7);
                    piva += temp2;
                    dostatekPiva -= temp2 * 0.5;
                    if(dostatekPiva < 0)
                    {
                        goto konecDne;
                    }
                }
                for (int f = 0; f < zeny; f++)
                {
                    double temp2 = rnd.Next(1, 4);
                    piva += temp2;
                    dostatekPiva -= temp2 * 0.5;
                    if (dostatekPiva < 0)
                    {
                        goto konecDne;
                    }
                }

                penize += piva * 30;
                konecDne:
                //Obidek
                int obidek = 0;
                int cenaObidku = 0;
                for (int h = 0; h < hosti; h++)
                {
                    if(rnd.Next(0, 101) <= 75)
                    {
                        obidek++;
                        cenaObidku += rnd.Next(60, 110);
                    }
                }
                penize += obidek * 149;
                penize -= cenaObidku;

                    if (penize >= cenaVystavby)
                    {
                        penize -= cenaVystavby;
                        cenaVystavby *= 1.5;
                        lidi *= 1.2;
                    }
                }
            //pokuta
            if (rnd.Next(0, 101) >= 35)
            {
                penize -= 100000;
            }
            }
            int penizeCW = Convert.ToInt32(penize);
            int lidiCW = Convert.ToInt32(lidi);
            int cenaVystavbyCW = Convert.ToInt32(cenaVystavby);
            Console.WriteLine("Máme " + penizeCW + "Kč");
            Console.WriteLine("Do hospody chodí 51 * " + lidiCW + " lidí.");
            Console.WriteLine("Cena výstavby je: " + cenaVystavbyCW + "Kč");
        }
    }
}
