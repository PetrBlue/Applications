using System;

namespace _1plus2plus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš hodnotu");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);
                y = y + i;
                Console.WriteLine(y);
                Console.WriteLine();
            }
        }
    }
}
