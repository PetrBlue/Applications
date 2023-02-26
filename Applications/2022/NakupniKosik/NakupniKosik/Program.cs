using System;
using System.Collections;

namespace NakupniKosik
{
    class Program
    {
        //IWD
        //Udelat nakupni kosik ktery nasledne ziska cenu, vyplivne celkovou cenu kosiku
        // budeme se pohybovat pomoci konzole
        //vystup: pole{rohlik, rajce, chleba} cena 300 kc

        //OBCHOD
        // Banán, Kebab, Ananas, Donut, Řízek, Rohlík, Párek
        // 32/110/40/10/80/2/20

        //Vypis kosiku, platba
        public static ArrayList kosikUzivatele = new ArrayList();
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v mém eshopu!");
            Dialog();
        }
        static void Dialog()
        {
            Console.WriteLine("Jakou potravinu potřebujete?");
            Console.WriteLine("Prodáváme: \r\n\t1) Banány \r\n\t2) Kebaby \r\n\t3) Ananasy \r\n\t4) Donuty \r\n\t5) Řízky \r\n\t6) Rohlíky \r\n\t7) Párky \r\n\t8) 'Zaplatit' pro zaplacení' 9) 'Kosik' pro zobrazení košíku");
            string potravina = Console.ReadLine();
            Console.WriteLine("Jaké si přejete množství zboží?");
            int mnozstvi = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < mnozstvi; i++)
            {
                kosikUzivatele.Add(potravina);
            }
        }
    }
}
