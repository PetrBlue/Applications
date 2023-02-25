using System;

namespace VahovyPrumer
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítej v Balakářích; nikdy nám nic nefunguje s.r.o.!");
            Console.ForegroundColor = ConsoleColor.White;
        loop:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš známku.");
            Console.WriteLine("Pokud chceš vidět průměr, napiš '0'");
            Console.ForegroundColor = ConsoleColor.White;
            float Znamka = int.Parse(Console.ReadLine());
            if(Znamka == 0)
            {
                if (a == 0 || b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("Žádné známky nebyly zadány.");
                    Console.WriteLine();
                    goto loop;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Znamka = (a / b);
                Console.WriteLine("Průměr je: " + Znamka);
                Console.WriteLine();
                goto loop;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš váhu známky.");
            Console.ForegroundColor = ConsoleColor.White;
            float Vaha = int.Parse(Console.ReadLine());
            a += Znamka * Vaha;
            b += Vaha;
            Console.Clear();
            goto loop;
        }
    }
}
