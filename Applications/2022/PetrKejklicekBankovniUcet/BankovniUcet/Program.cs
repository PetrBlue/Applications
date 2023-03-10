using System;
using System.Threading;

namespace BankovniUcet
{
    class Program
    {
        /*napiš program pro bankovní účet, kde bude možné:
        kouknout se na zůstatek na účtě                                                 - ano pres SpravaUctu();
        na zůstatek se může podívat pouze vlastník účtu                                 - ano pres specialni pin kod zadany uzivatelem
        bude možné vložit či vybrat peníze                                              - ano hotovo pres SpravaUctu();

        a zároveň nebude možné:                                                         
        nebudu si moci nastavit zůstatek na účtu (penize = x)                           - netusim jak, uzivatel nema pristup ke kodu
        nemůžeme vybrat více peněz, než je na účtě                                      - ano hotovo skrz podminku

        vytvoř minimálně 2 účty, kde každý účet získá 1000kč jako vstupní bonus.        - !!!!!!!!!!!!!!!!!!! (napsal jsem ucitelovi)
        uživatel a bude chtít na účet přidat okamžitě 2000kč                            - !!!!!!!!!!!!!!!!!!!
        uživatel b bude chtít vybrat ze svého účtu 1500kč                               - !!!!!!!!!!!!!!!!!!!

        v aplikaci se bude moci pohybovat pomocí konzole.*/

        public static int penize = 1000;
        public static int pin;
        public static int pin2;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vytvoř čtyřmístný pin kód, který bude vyžadován k dalším manipulacím s bankovním účtem.");
            Console.ForegroundColor = ConsoleColor.White;
            pin = Int32.Parse(Console.ReadLine());
            if(pin > 10000 || pin < 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Prosím zadejte platný čtyřmístní pin kód");
                Thread.Sleep(4000);
                Main();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Děkuji za vytvoření pin kódu \"{0}\", bude použit při dalších manipulacích s bankovním účtem.", pin);
            Thread.Sleep(4000);
            Console.Clear();
            Uvod();
        }
        static void Uvod()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítej v bankovním účtu");
            Console.WriteLine("Vyber možnost \n  1) Spravovat Účet");
            Console.ForegroundColor = ConsoleColor.White;
            int volba = Int32.Parse(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    Console.Clear();
                    SpravaUctu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Špatně zadaná hodnota");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Uvod();
                    break;
            }
        }
        static void SpravaUctu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Na účtu je {0} Korun Českých.", penize);
            Console.Write("Pro další manipulaci prosím zadejte Váš pin kód: ");
            int pin2 = Int32.Parse(Console.ReadLine());
            if(pin != pin2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatně zadaný pin kód!");
                Thread.Sleep(3000);
                Console.Clear();
                SpravaUctu();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pin kód byl přijat...načítání účtu");
            Thread.Sleep(4000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Co chcete udělat dále? \n  1) Vložit peníze \n  2) Vybrat peníze \n  3) Zpět do menu");
            int volba = Int32.Parse(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Napište hodnotu vložení: ");
                    int temp = Int32.Parse(Console.ReadLine());
                    if (temp > 0)
                    {
                        penize += temp;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hodnota byla vložena do bankovního účtu.");
                        Thread.Sleep(4000);
                        Console.Clear();
                        SpravaUctu();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Negativní číslo!");
                        Thread.Sleep(4000);
                        Console.Clear();
                        SpravaUctu();
                    }
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Napište hodnotu výběru: ");
                    int temp2 = Int32.Parse(Console.ReadLine());
                    if (temp2 > 0 && penize >= temp2)
                    {
                        penize -= temp2;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hodnota byla vybrána z bankovního účtu.");
                        Thread.Sleep(4000);
                        Console.Clear();
                        SpravaUctu();
                    }else if(penize < temp2){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nedostatek peněz na účtě.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        SpravaUctu();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Negativní číslo!");
                        Thread.Sleep(4000);
                        Console.Clear();
                        SpravaUctu();
                    }
                    break;
                case 3:
                    Console.WriteLine("Vracím se zpět do menu...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Uvod();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Špatně zadaná hodnota");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Uvod();
                    break;
            }
        }
    }
}