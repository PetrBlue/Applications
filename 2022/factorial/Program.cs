using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hodnota faktoriálu");
            int factorialNumber = int.Parse(Console.ReadLine());
            int vysledek = 1;
            for(int i = 1; i <= factorialNumber; i++)
            {
                vysledek = vysledek * i;
            }
            Console.WriteLine(vysledek);
        }
    }
}
