using System;

namespace NejvetsiSpolecnyDelitel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš hodnotu čísla a");
            Console.ForegroundColor = ConsoleColor.White;
            int a = int.Parse(Console.ReadLine());
            int aa = a;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš hodnotu čísla b");
            Console.ForegroundColor = ConsoleColor.White;
            int b = int.Parse(Console.ReadLine());
            int bb = b;
            while(a!=b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Největší společný dělitel " + aa + " a " + bb + " je: " + a);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
