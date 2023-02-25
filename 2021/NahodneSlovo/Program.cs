 using System;

namespace NahodneSlova
    {
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                string pismenka = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] polePismenek = pismenka.ToLower().ToCharArray();
                string slovicko = "";
                Console.WriteLine("Napište slovo");
                string hadaneSlovo = Console.ReadLine();
                Console.WriteLine("Napište kolik pokusů chcete :)");
                int pocetGenerovanychSlov = int.Parse(Console.ReadLine());
                //generator poctu slov
                for (int j = 0; j < pocetGenerovanychSlov; j++)
                {
                    //Generator random slov
                    for (int i = 0; i < hadaneSlovo.Length; i++)
                    {
                        slovicko += polePismenek[rnd.Next(0, polePismenek.Length)];
                    }
                    foreach (var item in hadaneSlovo)
                    {
                        if (slovicko == hadaneSlovo)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine();
                            Console.WriteLine("Slovo bylo nalezeno! Slovo: " + slovicko);
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(slovicko);
                    Console.ForegroundColor = ConsoleColor.White;
                    slovicko = "";
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("Žádné slova nebyly nalezeny :c");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

