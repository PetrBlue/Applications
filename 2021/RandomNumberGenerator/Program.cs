using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            bool bezihra = true;

            Random rnd = new Random();
            int guess = rnd.Next(a, b);
            while (bezihra == true);
            Console.WriteLine("Napiš hádané číslo od 1 do 100");
            int vstup = int.Parse(Console.ReadLine());
            Console.ReadLine();
            
            if (vstup == guess)
            {
                Console.WriteLine("Správné číslo!");
                bezihra = false;
            }
            else if (vstup <= guess)
            {
                Console.WriteLine("Menší číslo!");
            }
            else if (vstup >= guess)
            {
                Console.WriteLine("Větší číslo!");
            }
        }
    }
}
