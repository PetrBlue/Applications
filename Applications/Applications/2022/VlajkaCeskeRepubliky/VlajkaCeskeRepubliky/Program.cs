using System;

namespace VlajkaCeskeRepubliky
{
    class Program
    {
        static void Main(string[] args)
        {
            //po 5 diagonalne
            //modra
            //
            /*
            Console.WriteLine("Napis voe velikost pokud si kokot (zaklad: 15), nejvice 59 jinak to blbne");
            int vel = int.Parse(Console.ReadLine());

            Console.Clear();

            string[,] pole = new string[vel, vel*4];

            for(int i = 0; i < vel; i++)
            {
                for(int j = 0; j < vel*4; j++)
                {
                    pole[i,j] = "█";
                    //horni modra
                    if (j <= vel*3-5 && j / 5 <= i)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    //dolni modra
                    if (j <= vel * 2 && i + j / 5 <= vel - 1 && i > vel/2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    //cervena
                    if (i > vel / 2 && i + j / 5 >= vel - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(pole[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();*/
            Console.WriteLine("Napis voe velikost pokud si kokot (zaklad: 15), nejvice 59 jinak to blbne");
            int vel = int.Parse(Console.ReadLine());

            Console.Clear();

            string[,] pole = new string[vel, (vel+vel/2)];
            Console.WriteLine("Česká vlajka");
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel + vel/2; j++)
                {
                    pole[i, j] = "██";
                    //modra
                    if(i >= j && i+j <= vel-1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    //cervena
                    else if (i >= vel/2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(pole[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            pole = new string[vel, (vel + vel / 2)];
            Console.WriteLine("Americká vlajka");
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel + vel / 2; j++)
                {
                    pole[i, j] = "██";
                    //hvezdy
                    if (i <= vel/3 && j <= vel/2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        pole[i, j] = "* ";
                    }
                    //cervena
                    else if (i%2==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(pole[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            pole = new string[vel, (vel + vel / 2)];
            Console.WriteLine("Finská vlajka");
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel + vel / 2; j++)
                {
                    pole[i, j] = "██";
                    //modra
                    if ((i > 2*vel/5 && i < 3*vel/5) || (j > 2 * vel / 5 && j < 3 * vel / 5))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    
                    Console.Write(pole[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            pole = new string[vel, (vel + vel / 2)];
            Console.WriteLine("Řecká vlajka");
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel + vel / 2; j++)
                {
                    pole[i, j] = "██";
                    //modra
                    if ((i > 2 * vel / 5 && i < 3 * vel / 5) || (j > 2 * vel / 5 && j < 3 * vel / 5))
                    {
                        if (i == 2)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (i % 1 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(pole[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
    }
}
