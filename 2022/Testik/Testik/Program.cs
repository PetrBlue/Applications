using System;

namespace Testik
{
    class Program
    {                   
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v mé aplikaci kalkulačka");
            if (x == 0)
            {
                Console.WriteLine("Napiš číslo x: ");
                x = int.Parse(Console.ReadLine());
            }
            Kalkulacka();
        }
        static void Kalkulacka()
        {
                Console.WriteLine("Napiš číslo y: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("\r\nCo chcete dělat? \r\n1) Sčítat \r\n2) Odčítat \r\n3) Násobit \r\n4) Dělit\r\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Scitani();
                        break;
                    case 2:
                        Odcitani();
                        break;
                    case 3:
                        Nasobeni();
                        break;
                    case 4:
                        Deleni();
                        break;
                    default:
                        Console.WriteLine(@"jsi kokot a neumis pouzivat kalkkulacku");
                        break;
                }
        }
        static void Scitani()
        {
            Console.Clear();
            x += y;
            Console.WriteLine("vysledek: " + x);
            Kalkulacka();
        }
        static void Odcitani()
        {
            Console.Clear();
            x -= y;
            Console.WriteLine("vysledek: " + y);
            Kalkulacka();
        }
        static void Nasobeni()
        {
            Console.Clear();
            x *= y;
            Console.WriteLine("vysledek: " + y);
            Kalkulacka();
        }
        static void Deleni()
        {
            Console.Clear();
            x /= y;
            Console.WriteLine("vysledek: " + y);
            Kalkulacka();
        }
    }
}
