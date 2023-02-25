using System;

namespace EukliduvAlgoritmus
{
    class Program
    {
        static void Main(string[] args)
        {
        loop:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš hodnotu čísla a");
            Console.ForegroundColor = ConsoleColor.White;
            int a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš hodnotu čísla b");
            Console.ForegroundColor = ConsoleColor.White;
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Největší společný dělitel je " + a);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
            if (a <= 0 || b <= 0)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Napsal jsi záporné číslo, zkus to znovu.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
            while(b!=0)
            {
                int temp = a%b;
                a = b;
                b = temp;
            }
            if (b == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Výsledek je: " + a);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
        }
    }
}
