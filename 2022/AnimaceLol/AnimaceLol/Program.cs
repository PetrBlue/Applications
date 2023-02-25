using System;
using System.Threading;

namespace AnimaceLol
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = " \u2588";
            string Y = " \u2591";
            Console.WriteLine("*20 nejlepší");
            Console.Write("Zadej velikost:");
            int vel = Int32.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 1; i < vel; i++)
            {
                for (int j = 1; j < vel; j++)
                {
                    if ((i - vel / 2) * (i - vel / 2) + (j - vel / 2) * (j - vel / 2) <= (vel / 2 * vel / 2))
                    {
                        Console.Write(X);
                    }
                    else
                    {
                        Console.Write(Y);
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 1; i < vel-vel/5; i++)
            {
                for (int j = 1; j < vel; j++)
                {
                    if ((i -  2* vel / 5) * (i - 2*vel/5) + (j - vel / 2) * (j - vel / 2) <= (vel / 2 * vel / 2))
                    {
                        Console.Write(X);
                    }
                    else
                    {
                        Console.Write(Y);
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 1; i < vel-vel/4; i++)
            {
                for (int j = 1; j < vel; j++)
                
                    if ((i - 3*vel / 8) * (i - 3*vel/8) + (j - vel / 2) * (j - vel / 2) <= (vel / 2 * vel / 2))
                    {
                        Console.Write(X);
                    }
                    else
                    {
                        Console.Write(Y);
                    }
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 1; i < vel-vel/3; i++)
            {
                for (int j = 1; j < vel; j++)
                {
                    if ((i - vel / 3) * (i - vel / 3) + (j - vel / 2) * (j - vel / 2) <= (vel / 2 * vel / 2))
                    {
                        Console.Write(X);
                    }
                    else
                    {
                        Console.Write(Y);
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 1; i < vel-vel/2; i++)
            {
                for (int j = 1; j < vel; j++)
                {
                    if ((i - vel / 4) * (i - vel / 4) + (j - vel / 2) * (j - vel / 2) <= (vel / 2 * vel / 2))
                    {
                        Console.Write(X);
                    }
                    else
                    {
                        Console.Write(Y);
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
        }
    }
}
