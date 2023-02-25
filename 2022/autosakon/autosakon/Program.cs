using System;

namespace autosakon
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto mojeAuto = new Auto(4, "Skoda", "Nejnovejsi");
            Console.WriteLine(mojeAuto);
            Console.WriteLine(mojeAuto.PocetKol);
            mojeAuto.VypisPocetKol();
            Autobus mojAutobos = new Autobus(6, "Tramvaj", "Nejstarsi");
            Console.WriteLine(mojAutobos);
            Console.WriteLine(mojAutobos.PocetKol);
            mojAutobos.VypisPocetKol();
            Console.WriteLine("Ahoj, nedavej mi petku plz.");
            
        }
    }
}