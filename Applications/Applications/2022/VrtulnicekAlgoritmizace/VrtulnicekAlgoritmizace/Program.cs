using System;

namespace VrtulnicekAlgoritmizace
{
    class Program
    {
        static void Main(string[] args)
        {
            int vel = int.Parse(Console.ReadLine());
            string[,] pole = new string[vel, vel];
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    if (i == j || i+j==vel-1 || i ==vel/2 || j == vel / 2 || i <= vel/2 && j == 0 || i >= vel / 2 && j == vel - 1 || i == 0 && j >= vel/2 || i == vel-1 && j <= vel/2)
                    {
                        pole[i, j] = "█";
                    }
                    else
                    {
                        pole[i, j] = ".";
                    }
                    Console.Write(pole[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
