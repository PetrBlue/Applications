using System;

namespace Nejvetsi_NejmensiARozdilCisel
{
    class Program
    {
        static void Main(string[] args)
        {
           loop:
            int nejvetsiCislo = 0;
            int nejmensiCislo = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej hodnotu čísla x:");
            Console.ForegroundColor = ConsoleColor.White;
            int x = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej hodnotu čísla y:");
            Console.ForegroundColor = ConsoleColor.White;
            int y = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadej hodnotu čísla z:");
            Console.ForegroundColor = ConsoleColor.White;
            int z = int.Parse(Console.ReadLine());

            if(x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Špatně zadané čísla.");
                goto loop;
            }
            if (x > y)
            {
                 nejvetsiCislo = x;
                if (y > z)
                {
                    nejmensiCislo = z;
                }
                else if (y < z)
                {
                    nejmensiCislo = y;
                }

                if (z > x)
                {
                    nejvetsiCislo = z;
                    goto rozdil;
                }
            }
            if (x < y)
            {
                nejvetsiCislo = y;
                if (x > z)
                {
                    nejmensiCislo = z;
                }
                else if(x < z)
                {
                    nejmensiCislo = x;
                }

                if (z > y)
                {
                    nejvetsiCislo = z;
                    goto rozdil;
                }
            }

        /* 
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O kolik či kolikrát? \r\n 1) O kolik \r\n 2) Kolikrát");
         Console.ForegroundColor = ConsoleColor.White;
         int volba = int.Parse(Console.ReadLine());
         if (volba == 1)
         {
             goto rozdil;
         }
         if (volba == 2)
         {
             goto kolikrat;
         }
         */

        rozdil:
            Console.WriteLine();
            int rozdil = nejvetsiCislo - nejmensiCislo;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Největší číslo je: " + nejvetsiCislo + ", nejmenším číslo je: " + nejmensiCislo + ". Rozdíl těchto dvou čísel je: " + rozdil + ".");
        //kolikrat:
            Console.WriteLine();
            float kolikrat = nejvetsiCislo / nejmensiCislo;
            float zbytek = nejvetsiCislo % nejmensiCislo;
            zbytek = 1 / zbytek;
            kolikrat = kolikrat + zbytek;
            Console.WriteLine("Největší číslo je: " + nejvetsiCislo + ", nejmenším číslo je: " + nejmensiCislo + ". Číslo " + nejvetsiCislo + " je " + kolikrat + "xkrát větší než číslo " + nejmensiCislo + ".");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Znovu? \r\n 1) Ano \r\n 2) Ne");
            Console.ForegroundColor = ConsoleColor.White;
            int volba = int.Parse(Console.ReadLine());
            if (volba == 1)
            {
                goto loop;
            }
            if (volba == 2)
            {
               return;
            }
        }
    }
}
