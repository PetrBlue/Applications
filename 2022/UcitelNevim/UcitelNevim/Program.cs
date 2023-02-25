using System;

namespace UcitelNevim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Jedna");
                    break;
                case 2:
                    Console.WriteLine("Dva");
                    break;
                case 3:
                    Console.WriteLine("Tři");
                    break;
                default:
                    Console.WriteLine("Poslední");
                    break;
            }
        }
    }
}
