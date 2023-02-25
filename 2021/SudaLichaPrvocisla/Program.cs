using System;

namespace SudaLichaPrvocisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš hodnotu x:");
            double x = int.Parse(Console.ReadLine());
            double xx = x;
            Console.WriteLine();
            if (x % 2 == 0)
            {
                Console.WriteLine("Číslo je sudé");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Číslo je liché");
                Console.WriteLine();
            }
            if (x == 1)
            {
                Console.WriteLine("Číslo 1 není prvočíslo");
                Console.WriteLine();
            }
            for(int i=2; i <= Math.Sqrt(x); i++)
            {
                if(x%1==0)
                {
                    Console.WriteLine("Číslo " + xx + " není prvočíslo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Číslo " + xx + " je prvočíslo");
                    Console.WriteLine();
                }
            }
        }
    }
}
