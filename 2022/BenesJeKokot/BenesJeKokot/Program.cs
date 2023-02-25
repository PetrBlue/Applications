using System;

namespace BenesJeKokot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej velikost pole: ");
            int vel = Int32.Parse(Console.ReadLine());
            int[,] pole = new int[vel,vel];
            Console.Clear();
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    pole[i, j] = Math.Abs(i - j);
                    Console.Write(pole[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Zmacknete jakoukoli klavesu na dalsi obrazec");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    pole[i, j] = Math.Abs(i + j - vel + 1);
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Zmacknete jakoukoli klavesu na dalsi obrazec");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    if((i < j && j < vel - 1) || (i > j && i + j > vel - 1))
                    {
                        pole[i, j] = Math.Abs(j - vel/2);
                        Console.Write(pole[i, j]);
                    }
                    else
                    {
                        pole[i, j] = Math.Abs(i - vel/2);
                        Console.Write(pole[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Zmacknete jakoukoli klavesu na dalsi obrazec");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    if ((i < vel/2 && j < vel/2) || (i < vel/2 && j > vel/2))
                    {
                        pole[i, j] = Math.Abs(i - j);
                        Console.Write(pole[i, j]);
                    }
                    else
                    {
                        pole[i, j] = Math.Abs(i + j - vel + 1);
                        Console.Write(pole[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Konec");
        }
    }
}
