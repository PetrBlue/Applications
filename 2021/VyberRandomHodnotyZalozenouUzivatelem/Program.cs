using System;

namespace VyberRandomHodnotyZalozenouUzivatelem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool hahaha = true;
            string[] cislicka = new string[3];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej mi hodnotu 1");
            Console.ForegroundColor = ConsoleColor.White;
            cislicka[0] = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej mi hodnotu 2");
            Console.ForegroundColor = ConsoleColor.White;
            cislicka[1] = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej mi hodnotu 3");
            Console.ForegroundColor = ConsoleColor.White;
            cislicka[2] = Console.ReadLine();
           loop:
            while (hahaha == true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Výherce je " + cislicka[rnd.Next(0, cislicka.Length - 1)]);
                Console.ForegroundColor = ConsoleColor.White;

                //dalsi hra, ano - dalsi vyherce, ne - konec

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chceš vybrat nového výherce? \r\n 1) Ano \r\n 2) Ne");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                switch (Console.ReadLine())
                {
                    case ("Ano"):
                    case ("yes"):
                    case ("ano"):
                    case ("A"):
                    case ("Yes"):
                    case ("y"):
                    case ("a"):
                    case ("Y"):
                        {

                            goto loop;
                        }
                    case ("Ne"):
                    case ("no"):
                    case ("ne"):
                    case ("n"):
                    case ("No"):
                    case ("N"):
                        {
                            hahaha = false;
                            break;
                        }

                }
            }
        }
    }
}
