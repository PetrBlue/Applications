using System;

namespace AlgoritmizaceHodina
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = " \u2588";
            string Y = " \u2591";
            Console.WriteLine("Prosím sudé číslo");
            Console.Write("Zadej velikost:");
            int vel = Int32.Parse(Console.ReadLine());

            //barva pozadi
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Clear();

            //Úhlopříčka nahoře
            for(int i = 0; i < vel/2; i++)
            {
                for (int j = 0; j < 6 * vel; j++)
                {
                    if (i + j - 3*vel < vel - 1)
                    {
                        Console.Write(Y);
                    }
                    else
                    {
                        Console.Write(X);
                    }
                }
                Console.WriteLine();
            }
            //Komín, úhlopříčka, Okýnko
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < 6 * vel; j++)
                {
                    if (j < vel || (i+j-5*vel/2<vel-1) && (j>3*vel/2) || (j>4*vel) && (j<11*vel/2))
                    {
                        Console.Write(Y);
                    }
                    else
                    {
                        Console.Write(X);
                    }
                }
                Console.WriteLine();
            }
            //Tělo
            for (int i = 0; i < 3*vel/2; i++)
            {
                for (int j = 0; j < 6 * vel; j++)
                {
                        Console.Write(X);
                }
                Console.WriteLine();
            }
            //Kola
            for (int i = 1; i < vel; i++)
            {
                for (int j = 1; j < 6 * vel; j++)
                {
                    if ((i-vel/2)*(i-vel/2)+(j-vel/2)*(j-vel/2) <= (vel/2*vel/2) || (j-9*vel/2)*(j-9*vel/2) + (i + vel/2)*(i + vel/2) <= (3*vel/2)*(3*vel)/2)
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
        }
    }
}
