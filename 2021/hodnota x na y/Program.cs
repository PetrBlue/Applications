using System;

namespace hodnota_x_na_y
{
    class Program
    {
        static void Main(string[] args)
        {
        loop:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítej v programu kde se počítá x na y :D");
            Console.WriteLine("Zadej klávesu 'Enter' pro pokračování :)");
            ConsoleKeyInfo EnterKey;
            while ((EnterKey = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (EnterKey.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        goto xyz;
                }
            }
            xyz:
            Console.WriteLine("Napiš hodnotu x:");
            Console.ForegroundColor = ConsoleColor.White;
            int x = int.Parse(Console.ReadLine());
            int z = x;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš hodnotu y:");
            Console.ForegroundColor = ConsoleColor.White;
            int y = int.Parse(Console.ReadLine());
            Console.Clear();
            if (y == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Výsledek je: 1");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
            if(y<0)
            {
                y *= -1;
                for (int i = 1; i < y; i++)
                {
                    z += x;
                }
                z = 1 / z;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Výsledek je: " + z);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
            else
            {
                for (int i = 1; i < y; i++)
                {
                    z *= x;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Výsledek je: " + z);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto loop;
            }
        }
    }
}
