using System;

namespace BinaryCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vítejte v kalkulačce bináru.");
            Console.Write("Vyberte prosím či potřebujete převod na binár (B) či decimání číslo (D): ");
            switch (Console.ReadLine())
            {
                case "B":
                case "b":
                    Binar();
                    break;
                case "D":
                case "d":
                    Decimal();
                    break;
                default:
                    break;
            }
        }
        static public void Binar()
        {
            Console.Write("Napiš Decimální číslo:");
            int cislo = Int32.Parse(Console.ReadLine());
            int[] poleCislo;
            for (int i = 0; 0 < cislo; i++)
            {

            }
            for (int i = 0; cislo > 0; i++)
            {

            }
        }
        static public void Decimal()
        {
            Console.Write("Napiš Binární číslo:");
            int cislo = Int32.Parse(Console.ReadLine());
            int cisloVypis = cislo;
            int vysledek = 0;
            int zaklad = 1;
            while (cislo > 0)
            {
                int temp = cislo % 10;
                cislo = cislo / 10;
                vysledek += temp * zaklad;
                zaklad = zaklad * 2;
            }
            Console.WriteLine("Vaše číslo binární číslo {0} je decimální {1}.\nZmáčkněte jakoukoli klávesu pro pokračování...", cisloVypis, vysledek);
            Console.ReadKey();
            Main();
        }
    }
}
