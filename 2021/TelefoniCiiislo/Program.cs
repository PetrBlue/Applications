using System;

namespace TelefoniCiiislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[9];
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Napiš tvoje tel číslo :P");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tvé číslo je +420");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
