using System;
using System.Threading;

namespace GeneraceKuponu
{
    class Program
    {
        static void Main(string[] args)
        {
                Random rnd = new Random();
                string znaky = "ABCDEFGHIJKLMNOPQESTUVWXYZ1234567890";
                string kupon = "";
                char choosed;
                for (int i = 0; i < 29; i++)
                {
                if (i % 4 == 0)
                {
                    kupon += "-";
                }
                else
                {
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Clear();
                        int cislo = rnd.Next(0, 30);
                        choosed = znaky[cislo];
                        Thread.Sleep(250);
                        Console.Write(kupon);
                        for(int k = kupon.Length; k < 29; k++)
                        {
                            Console.Write(znaky[rnd.Next(0, 30)]);
                            if (k % 4 == 0)
                            {
                                kupon += "-";
                            }
                        }
                        if (j == 3)
                        {
                            kupon += znaky[cislo];
                            Console.Write(kupon);
                        }
                    }
                }
                }
                Console.WriteLine();
        }
    }
}
