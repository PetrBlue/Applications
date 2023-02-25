using System;

namespace Automechanik
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int vydelek = 0;
            int vydelekbezDane;
            
            for(int i = 0; i < 60; i++)
            {
                vydelek += rnd.Next(4382, 12115) * 2;
                int sanceNaTip = rnd.Next(0, 101);
                if(sanceNaTip >= 50)
                {
                    vydelek += rnd.Next(10, 201);
                }
                vydelek -= 300;
                if(i%7 == 0)
                {
                    vydelek -= 6300;
                }
            }
            vydelekbezDane = vydelek / 100 * 115;
            Console.WriteLine("Výdělek je " + vydelek + "Kč.");
            Console.WriteLine("Výdělek bez daně je " + vydelekbezDane + "Kč.");
        }
    }
}
