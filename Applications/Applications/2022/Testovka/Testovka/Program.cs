using System;

namespace Testovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Random rnd = new Random();
            int velPole = rnd.Next(10, 40);
            int[] pole = new int[velPole];
            int[] pole2 = new int[(velPole+1)/2];
            int vysledek = 0;
            Console.Write("Pole 1: ");
            for(int i = 0; i < velPole; i++)
            {
                pole[i] = rnd.Next(1, 40);
                vysledek += pole[i];
                Console.Write(pole[i] + ", ");
                if(i%2 == 0)
                {
                    pole2[i / 2] = pole[i];
                }
            }
            Console.Write("\r\n\r\nPole 2: ");
            for(int i = 0; i < velPole / 2; i++)
            {
                Console.Write(pole2[i] + ", ");
            }
            Console.WriteLine("\r\n\r\nVýsledek: " + vysledek + "\r\n");
            for(int i = 0; i < velPole/2; i++)
            {
                if(pole[i] > pole2[i])
                {
                    Console.WriteLine(pole[i] + " > " + pole2[i]);
                }
                if (pole2[i] > pole[i])
                {
                    Console.WriteLine(pole[i] + " < " + pole2[i]);
                }
                if (pole[i] == pole2[i])
                {
                    Console.WriteLine(pole[i] + " = " + pole2[i]);
                }
            }
        }
    }
}