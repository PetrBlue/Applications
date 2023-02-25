using System;

namespace CiselneRady1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej velikost pole");
            int vel = int.Parse(Console.ReadLine());
            int[] pole =  new int[vel];
            int a = 1;
            int b = 9;
            int c = 17;
            for (int i = 0; i < vel; i += 3)
            {
                pole[i] = a;
                Console.WriteLine(pole[i]);
                a++;
                if (i+1 < vel)
                {
                    pole[i + 1] = b;
                    Console.WriteLine(pole[i + 1]);
                    b++;
                }
                if (i+2 < vel)
                {
                    pole[i + 2] = c;
                    Console.WriteLine(pole[i + 2]);
                    c++;
                }
            }   
        }
    }
}
