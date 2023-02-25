using System;

namespace HayDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Welcome in application Hay Day Calculator! \r\n What do you want to do? \r\n  1) Calculate Bems \r\n  2) Calculate Price \r\n  3) Calculate Deco price \r\n  4) Barn size calculator");
            switch (Console.ReadLine())
            {
                case "1":
                    goto bemTrade;
                case "2":
                    goto coinTrade;
                case "3":
                    goto decoCalculator;
                case "4":
                    goto barnSizeCalculator;
                default:
                    Console.WriteLine("U r retarted!");
                    goto start;
            }
                bemTrade:

                coinTrade:

                decoCalculator:
                    Console.WriteLine("Write the cost bfr purchase");
                    int zacatecniCena = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the cost after purchase");
                    int finalniCena = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the quantity");
                    int quantity = int.Parse(Console.ReadLine());
                    int rozdil = finalniCena - zacatecniCena;
                    int totalniCena = 0;
                    if(quantity % 2 == 0)
                    {
                        totalniCena = quantity / 2 * (2 * zacatecniCena + (quantity - 1) * rozdil);
                    }
                    if (quantity % 2 == 1)
                    {
                        totalniCena = (quantity + 1) / 2 * (2 * zacatecniCena + (quantity - 1) * rozdil);
                    }
                    Console.WriteLine("The final cost is: " + totalniCena);

                barnSizeCalculator:
                    Console.WriteLine();
        }
    }
}
