
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
            string[] hadaneSlovo = { "pes", "dum", "bum", "sus", "puk", "oko", };
            int pocetGenerovanychSlov = 1000;
            //generator poctu slov
            for (int j = 0; j < pocetGenerovanychSlov; j++)
            {
                //Generator random slov
                for (int i = 0; i < hadaneSlovo[0].Length; i++)
                {
                    slovicko += polePismenek[rnd.Next(0, polePismenek.Length)];
                }
                foreach(var item in hadaneSlovo)
                {
                    if(slovicko == item)
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
