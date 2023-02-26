using System;
using System.Threading;

namespace PrevodDoRimskychCislic
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítejte v programu na převod římských číslic na decimální či decimální na římské.");
            Console.Write("Jaký převod potřebujete? \n  (R) Převod z decimálních na římské číslice\n  (D) Převod z římských na decimální číslice \nVaše volba: ");
            Console.ForegroundColor = ConsoleColor.White;
            switch (Console.ReadLine())
            {
                case "r":
                case "R":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Napište decimální číslo zde: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int DecimalniCislo = int.Parse(Console.ReadLine());
                    RimskeCislice(DecimalniCislo);
                    break;
                case "d":
                case "D":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Napište římské číslo zde: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string RimskeCislo = Console.ReadLine();
                    DecimalniCislice(RimskeCislo);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Špatná volba, prosím vyberte pouze z možností \"R\" či \"D\"");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Main();
                    break;
            }
        }
        public static string RimskeCislice(int cislo)
        {
            int vypis = cislo;
            int[] decimalniPole = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] rimskePole = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string vysledek = "";

            for(int i = 0; i < decimalniPole.Length; i++)
            {
                while(cislo >= decimalniPole[i])
                {
                    vysledek += rimskePole[i];
                    cislo -= decimalniPole[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nZ čísla {0} je římské číslo {1}", vypis, vysledek);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(4000);
            Console.Clear();
            Main();
            return vysledek;
        }
        public static int DecimalniCislice(string cislo)
        {
            string vypis = cislo;
            cislo += "   ";
            int vysledek = 0;
            for (int i = 0; i < cislo.Length; i++)
            {
                switch (cislo[i])
                {
                    case 'M': vysledek += 1000; break;
                    case 'D':
                        if (cislo[i + 1] == 'D')
                        { vysledek = 0; return vysledek; }
                        else { vysledek += 500; }
                        break;
                    case 'C':
                        if ((cislo[i + 1] == 'C') &&
                      (cislo[i + 2] == 'C') &&
                      (cislo[i + 3] == 'C'))
                        { vysledek = 0; return vysledek; }
                        if ((cislo[i + 1] == 'D') ||
                            (cislo[i + 1] == 'M'))
                        { vysledek -= 100; }
                        else { vysledek += 100; }
                        break;
                    case 'L':
                        if ((cislo[i + 1] == 'L') || (cislo[i + 1] == 'M') ||
                      (cislo[i + 1] == 'D'))
                        { vysledek = 0; return vysledek; }
                        else { vysledek += 50; }
                        break;
                    case 'X':
                        if (((cislo[i + 1] == 'X') &&
                      (cislo[i + 2] == 'X') &&
                      (cislo[i + 3] == 'X')) ||
                      (cislo[i + 1] == 'M') ||
                      (cislo[i + 1] == 'D'))
                        { vysledek = 0; return vysledek; }
                        if ((cislo[i + 1] == 'L') ||
                            (cislo[i + 1] == 'C'))
                        { vysledek -= 10; }
                        else { vysledek += 10; }
                        break;
                    case 'V':
                        if ((cislo[i + 1] == 'V') ||
                      (cislo[i + 1] == 'M') ||
                      (cislo[i + 1] == 'D') ||
                      (cislo[i + 1] == 'C') ||
                      (cislo[i + 1] == 'L') ||
                      (cislo[i + 1] == 'X'))
                        { vysledek = 0; return vysledek; }
                        else { vysledek += 5; }
                        break;
                    case 'I':
                        if (((cislo[i + 1] == 'I') &&
                      (cislo[i + 2] == 'I') &&
                      (cislo[i + 3] == 'I')) ||
                      (cislo[i + 1] == 'M') ||
                      (cislo[i + 1] == 'D') ||
                      (cislo[i + 1] == 'C') ||
                      (cislo[i + 1] == 'L'))
                        { vysledek = 0; return vysledek; }
                        if ((cislo[i + 1] == 'V') ||
                            (cislo[i + 1] == 'X'))
                        {  vysledek -= 1; }
                        else { vysledek += 1; }
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nZ čísla {0} je decimální číslo {1}", vypis, vysledek);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(4000);
            Console.Clear();
            Main();
            return vysledek;
        }
    }
}
