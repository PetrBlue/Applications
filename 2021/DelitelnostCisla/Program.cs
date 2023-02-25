using System;

namespace DelitelnostCisla
{
    class Program
    {
        static void Main(string[] args)
        {
        loop:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítejte v aplikaci 'Čím vším je toto číslo dělitelné?'");
            Console.WriteLine();
            Console.WriteLine("Napiš hodnotu čísla x, u kterého by jsi chtěl znát všsechny dělitele :D");
            Console.ForegroundColor = ConsoleColor.White;
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if(x%i==0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(i + ", ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();
            goto loop;
        }
    }
}
