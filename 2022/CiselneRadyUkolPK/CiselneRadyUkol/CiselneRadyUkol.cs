using System;

namespace CiselneRadyUkol
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítej v úkolu. Vyber si co chtěl z číselných řad");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("  1) Čísla od 0 do 20 \r\n  2) Násobky čísla 2 \r\n  3) Součet čísel menších než 25 \r\n  4) Číselná řada, liché číslo je násobkem šesti, sudé číslo je násobkem sedmičky \r\n  5) Číselná řada, každé číslo je o 0,25 menší než to první \r\n  6) Vypíše číslo záporné pak kladné \r\n  7) Mocniny Dvou od 0 do 16 \r\n  8) Faktoriál čísla \r\n  9) Fibonacciho Posloupnost \r\n 10) Tabulka Násobilky");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Zadané číslo:");
            Console.ForegroundColor = ConsoleColor.White;
            switch (Console.ReadLine())
            {
                case "1":
                    CislaOdNulyDoDvaceti();
                    break;
                case "2":
                    NasobilkaDvou();
                    break;
                case "3":
                    ScitaniCiselJednaAzDvacet();
                    break;
                case "4":
                    LichySestSudySedm();
                    break;
                case "5":
                    MensiOCtvrt();
                    break;
                case "6":
                    VypiseCisloZapornePakKladne();
                    break;
                case "7":
                    MocninyDvou();
                    break;
                case "8":
                    Faktorial();
                    break;
                case "9":
                    FibonaccihoPosloupnost();
                    break;
                case "10":
                    TabulkaNasobilky();
                    break;
                default:
                    return;
            }
            
        }
        public static void CislaOdNulyDoDvaceti()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.WriteLine("Číselná řada od 0 do 20");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + ", ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void NasobilkaDvou()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.WriteLine("Násobky čísla 2");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + ", ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void ScitaniCiselJednaAzDvacet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            int soucet = 0;
            Console.WriteLine("Součet čísel menších než 25");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 25; i++)
            {
                soucet += i;
            }
            Console.WriteLine(soucet);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void LichySestSudySedm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            int nasobkySesti = 6;
            int nasobkySedmi = 7;
            Console.WriteLine("Číselná řada, liché číslo je násobkem šesti, sudé číslo je násobkem sedmičky");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.Write(nasobkySesti + ", ");
                    nasobkySesti += 6;
                }
                else
                {
                    Console.Write(nasobkySedmi + ", ");
                    nasobkySedmi += 7;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void MensiOCtvrt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            double cislo = -1;
            Console.WriteLine("Číselná řada, každé číslo je o 0,25 menší než to první");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                cislo -= 0.25;
                Console.Write(cislo + ", ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void VypiseCisloZapornePakKladne()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;            
            Console.WriteLine("Vypíše číslo záporné pak kladné");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("0, ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(-i + ", ");
                Console.Write(i + ", ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void MocninyDvou()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.WriteLine("Mocniny Dvou od 0 do 16");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            double vysledek;
            for (int i = 0; i <= 16; i++)
            {
                vysledek = Math.Pow(2, i);
                Console.WriteLine("2^" + i + " = " + vysledek);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Faktorial()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.WriteLine("Zadejte číslo faktoriálu");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int fak = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadejte jste číslo: " + fak);
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            double vysledek = 1;
            for (int i = 1; i <= fak; i++)
            {
                vysledek *= i;
            }
            Console.WriteLine("Faktoriál čísla " + fak + " je " + vysledek + ".");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void FibonaccihoPosloupnost()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fibonacciho Posloupnost");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int prvniCislo = 1;
            int druheCislo = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(prvniCislo + ", " + druheCislo + ", ");
                prvniCislo += druheCislo;
                druheCislo += prvniCislo;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void TabulkaNasobilky()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo keyyInfo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tabulka Násobilky");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int vysledek = 1;
            for(int j = 1; j <= 10; j++)
            {
                for(int i = 1; i <= 10; i++)
                {
                    vysledek = j * i;
                    Console.Write(vysledek + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stisněte tlačítko Enter pro návrat...");
            while ((keyyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Main();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}