using System;

namespace Pizzerie
{
    internal class Program
    {
//////////        [SKLADIŠTĚ]
//////////    Ingredience
//////////        Koření
//////////        Šunka
//////////        Těsto
//////////        Sýr
//////////            Eidam
//////////            Gouda
//////////            Parmazán
//////////            Plesnivý sýr
//////////        Protlak
//////////        Smetana
//////////[PIZZERIA]
//////////    Pec
//////////        Plná/Prázdná
//////////        Kapacita
//////////    Metody
//////////        VyrobPizzu()
//////////        VlozDoPece()
//////////        VyndejZPece()
//////////    TODO
//////////        Stůl
//////////        Kapacita pizzerie
//////////        Metody:
//////////            ZapalPec()
//////////            UhasPec()
//////////[ŠUNKOVÁ PIZZA]
//////////    Ingredience
//////////        Těsto
//////////        Šunka
//////////        Protlak
//////////    Metody Override
//////////        VyrobPizzu()
//////////[QUATRO FORMAGI]
//////////    Ingredience
//////////        Těsto
//////////        Šunka
//////////        Protlak
//////////    Metody Override
//////////        VyrobPizzu()
//////////
//////////TODO
//////////    Zaměstnanci
//////////    Objednávky
//////////    Zákazníci
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cus voe, nemame pizzu, check back ltr plz.");
            Console.WriteLine("NE");
            Skladiste skladiste = new Skladiste();
            skladiste.VypisPotraviny();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}