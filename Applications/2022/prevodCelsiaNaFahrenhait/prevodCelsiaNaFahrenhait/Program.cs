using System;

namespace prevodCelsiaNaFahrenhait
{
    class Program
    {
        //zadejte hodnotu 0-200
        //Celsius(); Fahrenheit();
        //celsius na fahr
        //fahr na cels
        //C = 1,8 * C + 32
        //(F − 32) × 5/9 = C
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítejte v programu na převod °C na °F");
            Console.WriteLine("Co potřebujete převést? \r\n\t1) Celsius na Fahrenheit \r\n\t2) Fahrenheit na Celsius");
            Console.ForegroundColor = ConsoleColor.White;
            int vyber = int.Parse(Console.ReadLine());
            if(vyber == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kolik °C chcete převést?");
                Console.ForegroundColor = ConsoleColor.White;
                double prevod = int.Parse(Console.ReadLine());
                double vysledek = (1.8 * prevod) + 32;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}C° je {1}F°.", prevod, vysledek);
            }
            else if(vyber == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kolik °F chcete převést?");
                Console.ForegroundColor = ConsoleColor.White;
                double prevod = int.Parse(Console.ReadLine());
                double vysledek = (prevod - 32) * 5/9;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}°C je {1}°F.", prevod, vysledek);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatný výběr!");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Konec");
        }
    }
}
