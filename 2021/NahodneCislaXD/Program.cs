using System;

namespace NahodneCislaXD
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 10;
            int yy = 100;
            int yyy = 1000;
            int yyyy = 1000000;
            int a = 0;
            bool haha = true;
            bool stavHry = true;
            bool playAgain = true;

            Random rnd = new();

        loop:
            if (x == 1)
            {
                haha = true;
            }

            if (haha == true)
            {
                if (a >= 100)
                {
                    Console.WriteLine("Gratuluji, máš " + a + " bodů");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Body = " + a + "\r\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Vyber si obtížnost :D");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\r\n (1 = Lehká za 1 bod) \r\n (2 = Normální za 2 body) \r\n (3 = Těžká za 5 bodů) \r\n (4 = Nemožná za 10 bodů)");
                Console.ForegroundColor = ConsoleColor.White;
                int obtiznost = int.Parse(Console.ReadLine());
                if (obtiznost == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Body = " + a + "\r\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hádej číslo od 1 do 10, napiš 0 a řeknu ti číslo");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (playAgain)
                    {
                        int hadaneCislo = rnd.Next(x, y);
                        if (stavHry == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Zahrát znovu?");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                            Console.ForegroundColor = ConsoleColor.White;

                            int playAgain2 = int.Parse(Console.ReadLine());
                            if (playAgain2 == 1)
                            {
                                stavHry = true;
                                haha = false;
                                Console.Clear();
                                goto loop;

                            }
                            else
                            {
                                return;
                            }
                        }
                        while (stavHry)
                        {
                        pool1:
                            int naseCislo = Int32.Parse(Console.ReadLine());
                            if (naseCislo == 0)
                                if (a >= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Chceš to číslo?");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    int Napoveda = int.Parse(Console.ReadLine());
                                    if (Napoveda == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tvé hádané číslo je " + hadaneCislo);
                                        Console.ForegroundColor = ConsoleColor.White;

                                        a -= 1;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tak nic :D, Hádej číslo");
                                        Console.ForegroundColor = ConsoleColor.White;

                                        goto pool1;
                                    }
                                }
                            if (naseCislo == hadaneCislo)
                            {
                                a++;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Nice, uhádl jsi to a získal 1 bod");
                                stavHry = false;
                            }
                            else if (0 < naseCislo && naseCislo < hadaneCislo)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Větší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (naseCislo > hadaneCislo)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Menší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                }
                else if (obtiznost == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Body = " + a + "\r\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hádej číslo od 1 do 100, napiš 0 a řeknu ti číslo");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (playAgain)
                    {
                        int hadaneCislo2 = rnd.Next(x, yy);

                        if (stavHry == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Zahrát Znovu?");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                            Console.ForegroundColor = ConsoleColor.White;

                            int playAgain2 = int.Parse(Console.ReadLine());

                            if (playAgain2 == 1)
                            {
                                stavHry = true;
                                haha = false;
                                Console.Clear();
                                goto loop;

                            }
                            else if (playAgain2 == 2)
                            {
                                return;
                            }
                        }
                        while (stavHry)

                        {
                        pool2:
                            int naseCislo2 = Int32.Parse(Console.ReadLine());

                            if (naseCislo2 == 0)
                                if (a >= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Chceš to číslo?");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    int Napoveda = int.Parse(Console.ReadLine());
                                    if (Napoveda == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tvé hádané číslo je " + hadaneCislo2);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        a -= 2;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tak nic :D, Hádej číslo");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto pool2;
                                    }
                                }
                            if (naseCislo2 == hadaneCislo2)
                            {
                                a += 2;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Nice, uhádl jsi to a získal 2 body");
                                stavHry = false;
                            }
                            else if (0 < naseCislo2 && naseCislo2 < hadaneCislo2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Větší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (naseCislo2 > hadaneCislo2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Menší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                }
                else if (obtiznost == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Body = " + a + "\r\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hádej číslo od 1 do 1000, napiš 0 a řeknu ti číslo");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (playAgain)
                    {
                        int hadaneCislo3 = rnd.Next(x, yyy);

                        if (stavHry == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Zahrát Znovu?");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                            Console.ForegroundColor = ConsoleColor.White;

                            int playAgain2 = int.Parse(Console.ReadLine());
                            if (playAgain2 == 1)
                            {
                                stavHry = true;
                                haha = false;
                                Console.Clear();
                                goto loop;

                            }
                            else if (playAgain2 == 2)
                            {
                                return;
                            }
                        }
                        while (stavHry)
                        {
                        pool3:
                            int naseCislo3 = Int32.Parse(Console.ReadLine());
                            if (naseCislo3 == 0)
                                if (a >= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Chceš to číslo?");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    int Napoveda = int.Parse(Console.ReadLine());
                                    if (Napoveda == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tvé hádané číslo je " + hadaneCislo3);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        a -= 5;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tak nic :D, Hádej číslo");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto pool3;
                                    }
                                }
                            if (naseCislo3 == hadaneCislo3)
                            {
                                a += 5;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Nice, uhádl jsi to a získal 5 bodů");
                                stavHry = false;
                            }
                            else if (0 < naseCislo3 && naseCislo3 < hadaneCislo3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Větší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (naseCislo3 > hadaneCislo3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Menší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                }
                else if (obtiznost == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Body = " + a + "\r\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hádej číslo od 1 do 1000000, napiš 0 a řeknu ti číslo");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (playAgain)
                    {
                        int hadaneCislo4 = rnd.Next(x, yyyy);

                        if (stavHry == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Zahrát Znovu?");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                            Console.ForegroundColor = ConsoleColor.White;

                            int playAgain2 = int.Parse(Console.ReadLine());
                            if (playAgain2 == 1)
                            {
                                stavHry = true;
                                haha = false;
                                Console.Clear();
                                goto loop;

                            }
                            else if (playAgain2 == 2)
                            {
                                return;
                            }
                        }
                        while (stavHry)
                        {
                        pool4:
                            int naseCislo4 = Int32.Parse(Console.ReadLine());
                            if (naseCislo4 == 0)
                                if (a >= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Chceš to číslo?");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\r\n (1 = Ano) \r\n (2 = Ne)");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    int Napoveda = int.Parse(Console.ReadLine());
                                    if (Napoveda == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tvé hádané číslo je " + hadaneCislo4);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        a -= 10;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Tak nic :D, Hádej číslo");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto pool4;
                                    }
                                }
                            if (naseCislo4 == hadaneCislo4)
                            {

                                a += 10;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Nice, uhádl jsi to a získal 10 bodů");
                                Console.ForegroundColor = ConsoleColor.White;
                                stavHry = false;
                            }
                            else if (0 < naseCislo4 && naseCislo4 < hadaneCislo4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Větší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (naseCislo4 > hadaneCislo4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Menší");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Špatně zadané číslo");
                }
            }
        }
    }

}