using System;

namespace kalkulackanaskolu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik Ti je let?");
            int vek = int.Parse(Console.ReadLine());
            if (vek >= 6 && vek <= 14)
            {
                Console.WriteLine("Jdeš na základní školu!");
            }
            else if (vek >= 15 && vek <= 18)
            {
                Console.WriteLine("Jdeš na střední školu!");
            }
            else if (vek >= 19 && vek <= 25)
            {
                Console.WriteLine("Jdeš na vysokou školu!");

            }
            else if (vek >= 26 && vek <= 65)
            {
                Console.WriteLine("Jdeš do práce!");

            }
            else if (vek >= 66 && vek <= 100)
            {
                Console.WriteLine("Jdeš do důchodu!");

            }
            else if (vek >= 6 && vek <= 3)
            {
                Console.WriteLine("Jdeš na vysokou školu!");

            }
            else
            {
                Console.WriteLine("Jsi mimino!");
            }
        }
    }
}
