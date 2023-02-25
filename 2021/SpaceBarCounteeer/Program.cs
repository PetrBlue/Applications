using System;

namespace SpaceBarCounteeer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítej.  Zde můžeš klikat pomocí mezerníku :) \r\n Mezerník - Zvýší počet o 1. \r\n R - Sníží číslo o vámi zadané číslo. \r\n Backspace - Zresetuje číslo. \r\n Tab - Nastaví barvu :D \r\n M - Ukáže toto menu :) \r\n Escape - Ukončí program :(");
            Console.ForegroundColor = ConsoleColor.White;
            int x = 0;
            ConsoleKeyInfo SpaceBarInfo;
            while ((SpaceBarInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (SpaceBarInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        x++;
                        Console.WriteLine(x);
                        System.Threading.Thread.Sleep(10);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        x -= x;
                        Console.WriteLine(x);
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine("Zadej číslo o které chceš číslo zmenšit");
                        int mensiCislo = int.Parse(Console.ReadLine());
                        x -= mensiCislo;
                        Console.WriteLine(x);
                        break;
                    case ConsoleKey.Tab:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Napiš barvu :) \r\n (Zatím pouze červenou, modrou, žlutou, zelenou a bílou)");
                        Console.ForegroundColor = ConsoleColor.White;
                        switch (Console.ReadLine())
                        {
                            case ("red"):
                            case ("červená"):
                            case ("Červená"):
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Barva změněna na červenou :)");
                                break;
                            case ("blue"):
                            case ("modrá"):
                            case ("Modrá"):
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Barva změněna na modrou :)");
                                break;
                            case ("yellow"):
                            case ("žlutá"):
                            case ("Žlutá"):
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Barva změněna na žlutou :)");
                                break;
                            case ("green"):
                            case ("zelená"):
                            case ("Zelená"):
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Barva změněna na zelenou :)");
                                break;
                            case ("white"):
                            case ("bílá"):
                            case ("Bílá"):
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Barva změněna na bílou :)");
                                break;

                        }
                        break;
                    case ConsoleKey.M:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Menu :) \r\n Mezerník - Zvýší počet o 1. \r\n Backspace - Zresetuje číslo. \r\n Tab - Nastaví barvu :D \r\n Escape - Ukončí program :(");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
