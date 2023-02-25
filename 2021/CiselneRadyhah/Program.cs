using System;

namespace CiselneRadyhah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš velikost pole:");
            int vel = int.Parse(Console.ReadLine());
            int[] ciselnaRada = new int[vel];
            int a = 1;
            int b = 9;
            int c = 17;
            for(int i = 0; i < vel; i += 3)
            {
                ciselnaRada[i] = a;
                ciselnaRada[i + 1] = b;
                ciselnaRada[i + 2] = c;
                a += 1;
                b += 1;
                c += 1;
            }
            for(int i = 0; i < vel; i++)
            {
                Console.WriteLine(ciselnaRada[i]);
            }
        }
    }
}
