using System;
using System.Threading;

namespace Sorts
{
    class Sorts
    {
        //done fn
        static public void Main()
        {
            //Dark Gray = ReadKey; Green = Info Text; Cyan = User Input; Red = Error; Dark Magenta = Answer
            //Napis, vyres (bez a s postupem) / Popis Procesu / Zpet
            string userInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This application was done by blue. Please do not steal this, thanks.");
            Thread.Sleep(250);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Heyo, vítám tě v mém programu na třídicí systémy.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Takže tu máme prozatím jen:\n\t1) Bubble Sort\n\t2) Select Sort\n\t3) Insert Sort\n\nProsím zde zadej číslo sortu, který by si chtěl spustit: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out int number) || (Int32.Parse(userInput) < 1 || Int32.Parse(userInput) > 3))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste správné číslo. Zvolte jednu ze zobrazených možností:\n\t1) Bubble Sort\n\t2) Select Sort\n\t3) Insert Sort\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();
                Console.Clear();
            }
            switch (userInput)
            {
                case "1":
                    BubbleSort();
                    break;
                case "2":
                    SelectSort();
                    break;
                case "3":
                    InsertSort();
                    break;
                default:
                    Console.WriteLine("Nevím jak jsi se sem dostal, prosím napiš mi tvé kroky.");
                    break;
            }
        }
        //done
        static public void BubbleSort()
        {
            Console.Clear();
            string temp;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej v sekci Bubble Sortu. Zde máš možnosti:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zde zadej číslo procesu, který by si chtěl spustit: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            temp = Console.ReadLine();
            while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < 1 || Int32.Parse(temp) > 3))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste číslo. Zvolte jednu ze zobrazených možností:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                temp = Console.ReadLine();
                Console.Clear();
            }
            switch (temp)
            {
                case "1":
                    VyreseniBubbleSortu();
                    break;
                case "2":
                    VysvetleniBubbleSortu();
                    break;
                case "3":
                    Console.Clear();
                    Main();
                    break;
                default:
                    break;
            }
        }
        //done
        static public void VyreseniBubbleSortu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Zadej velikost pole: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string vel = Console.ReadLine();
            while (!Int32.TryParse(vel, out int number) || (Int32.Parse(vel) < -128 || Int32.Parse(vel) > 128))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                vel = Console.ReadLine();
                Console.Clear();
            }
            int[] pole = new int[Int32.Parse(vel)];
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Na indexu [{i}] vyplň číslo od -128 do 128: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < -128 || Int32.Parse(temp) > 128))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\n\nProsím zkuste to znovu: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    temp = Console.ReadLine();
                    Console.Clear();
                }
                pole[i] = Int32.Parse(temp);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete vidět postup?\n\t1) Ano\n\t2) Ne\nProsím zde zadejte hodnotu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string videtPostup = Console.ReadLine();
            while (!Int32.TryParse(videtPostup, out int number) || (Int32.Parse(videtPostup) < 1 || Int32.Parse(videtPostup) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od 1 do 2.\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                videtPostup = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                if (Int32.Parse(videtPostup) == 2)
                {
                    if (i == 0 || i == pole.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        for (int x = 0; x < pole.Length - 1; x++)
                        {
                            if (x == 0)
                            {
                                Console.Write("[");
                            }
                            Console.Write(pole[x] + ", ");
                            if (x == pole.Length - 2)
                            {
                                Console.WriteLine(pole[x + 1] + "]");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                }
                if (Int32.Parse(videtPostup) == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    for (int x = 0; x < pole.Length - 1; x++)
                    {
                        if (x == 0)
                        {
                            Console.Write("[");
                        }
                        Console.Write(pole[x] + ", ");
                        if (x == pole.Length - 2)
                        {
                            Console.WriteLine(pole[x + 1] + "]");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                for (int j = 0; j < pole.Length - i - 1; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        int temp = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = temp;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string volbaKonec = Console.ReadLine();
            while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                volbaKonec = Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (Int32.Parse(volbaKonec) == 1)
            {
                Main();
            }
            else if (Int32.Parse(volbaKonec) == 2)
            {
                return;
            }
        }
        //done
        static public void VysvetleniBubbleSortu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Bublinkové řazení (známé pod anglickým jménem bubble sort, česky též řazení záměnou) je implementačně jednoduchý řadicí algoritmus.\nAlgoritmus opakovaně prochází seznam, přičemž porovnává každé dva sousedící prvky, a pokud nejsou ve správném pořadí, prohodí je.\nPro praktické účely je neefektivní, využívá se hlavně pro výukové účely či v nenáročných aplikacích.\nAlgoritmus je univerzální (pracuje na základě porovnávání dvojic prvků), pracuje lokálně (nevyžaduje pomocnou paměť), je stabilní (prvkům se stejným klíčem nemění vzájemnou polohu), patří mezi přirozené řadicí algoritmy (částečně seřazený seznam zpracuje rychleji než neseřazený).\nNázev vyjadřuje průběh zpracování, při kterém prvky s vyšší hodnotou „probublávají“ na konec seznamu. Optimalizací algoritmu je detekce prohození prvků v průchodu seznamu.\nV případě, že algoritmus v průchodu neprohodil žádné dva prvky, tak žádné další prvky již nikdy neprohodí.\nTudíž řazení můžeme ukončit s tím, že seznam je seřazen.\nPříklad:\n(3 2 8 7 6) zadání pole, řaďmě od největšího k nejmenšímu\n(3 2 8 7 6) // 3 a 2 jsou v korektním pořadí, posuňme se o index\n(3 2 8 7 6) // 8 > 2, prohoďme je\n(3 8 2 7 6) // 7 > 2, prohoďme je (zde je vidět probublávání nejlehčí dvojky vzhůru)\n(3 8 7 2 6) // 6 > 2, prohoďme je\n(3 8 7 6 2) // nový průchod polem: na posledním místě je nejlehčí prvek, tudíž se nám řazená úloha o jedna zkrátila, 8 > 3, prohoďme je\n(8 3 7 6 2) // 7 > 3, prohoďme je\n(8 7 3 6 2) // 6 > 3, prohoďme je\n(8 7 6 3 2) // seřazeno");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string volbaKonec = Console.ReadLine();
            while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                volbaKonec = Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (Int32.Parse(volbaKonec) == 1)
            {
                Main();
            }
            else if (Int32.Parse(volbaKonec) == 2)
            {
                return;
            }
        }
        //done
        static public void SelectSort()
        {
            Console.Clear();
            string temp;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej v sekci Bubble Sortu. Zde máš možnosti:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zde zadej číslo procesu, který by si chtěl spustit: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            temp = Console.ReadLine();
            while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < 1 || Int32.Parse(temp) > 3))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste číslo. Zvolte jednu ze zobrazených možností:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                temp = Console.ReadLine();
                Console.Clear();
            }
            switch (temp)
            {
                case "1":
                    VyreseniSelectSortu();
                    break;
                case "2":
                    VysvetleniSelectSortu();
                    break;
                case "3":
                    Console.Clear();
                    Main();
                    break;
                default:
                    break;
            }
        }
        //done
        static public void VyreseniSelectSortu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Zadej velikost pole: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string vel = Console.ReadLine();
            while (!Int32.TryParse(vel, out int number) || (Int32.Parse(vel) < -128 || Int32.Parse(vel) > 128))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                vel = Console.ReadLine();
                Console.Clear();
            }
            int[] pole = new int[Int32.Parse(vel)];
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Na indexu [{i}] vyplň číslo od -128 do 128: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < -128 || Int32.Parse(temp) > 128))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\nProsím zkuste to znovu: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    temp = Console.ReadLine();
                    Console.Clear();
                }
                pole[i] = Int32.Parse(temp);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete vidět postup?\n\t1) Ano\n\t2) Ne\n\nProsím zde zadejte hodnotu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string videtPostup = Console.ReadLine();
            while (!Int32.TryParse(videtPostup, out int number) || (Int32.Parse(videtPostup) < 1 || Int32.Parse(videtPostup) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od 1 do 2.\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                videtPostup = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                if (Int32.Parse(videtPostup) == 2)
                {
                    if (i == 0 || i == pole.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        for (int x = 0; x < pole.Length - 1; x++)
                        {
                            if (x == 0)
                            {
                                Console.Write("[");
                            }
                            Console.Write(pole[x] + ", ");
                            if (x == pole.Length - 2)
                            {
                                Console.WriteLine(pole[x + 1] + "]");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (Int32.Parse(videtPostup) == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    for (int x = 0; x < pole.Length - 1; x++)
                    {
                        if (x == 0)
                        {
                            Console.Write("[");
                        }
                        Console.Write(pole[x] + ", ");
                        if (x == pole.Length - 2)
                        {
                            Console.WriteLine(pole[x + 1] + "]");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                int m = i;
                for (int j = i + 1; j < Int32.Parse(vel); j++)
                {
                    if (pole[m] > pole[j])
                    {
                        m = j;
                    }
                }
                int temp = pole[m];
                pole[m] = pole[i];
                pole[i] = temp;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string volbaKonec = Console.ReadLine();
            while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                volbaKonec = Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (Int32.Parse(volbaKonec) == 1)
            {
                Main();
            }
            else if (Int32.Parse(volbaKonec) == 2)
            {
                return;
            }
        }
        //done
        static public void VysvetleniSelectSortu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Řazení výběrem je v informatice implementačně jednoduchý řadicí algoritmus s časovou složitostí O(N²).\nPro svou jednoduchou implementaci a nízký overhead bývá často používán pro uspořádávání malých množství dat. Pro větší objem dat se používají algoritmy s nižší časovou složitostí O(N log N) jako řazení haldou nebo řazení slučováním.\nAlgoritmus je univerzální (pracuje na základě porovnávání dvojic prvků), pracuje lokálně (nevyžaduje pomocnou paměť), není stabilním (prvkům se stejným klíčem může změnit vzájemnou polohu) a nepatří mezi přirozené řadicí algoritmy (částečně seřazený seznam se bude zpracovávat stejně dlouho jako neseřazený).\nPříklad:\n(3 2 8 7 6) // zadání pole, řaďmě od největšího k nejmenšímu\n(3 2 8 7 6) // nejvyšší číslo je 8, prohoďme ho tedy s číslem 3 na indexu 0\n(8 2 3 7 6) // nejvyšší číslo je 7, prohoďme ho tedy s číslem 2 na indexu 1\n(8 7 3 2 6) // nejvyšší číslo je 6, prohoďme ho tedy s číslem 3 na indexu 2\n(8 7 6 2 3) // nejvyšší číslo je 3, prohoďme ho tedy s číslem 2 na indexu 3\n(8 7 6 3 2) // seřazeno");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string volbaKonec = Console.ReadLine();
            while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                volbaKonec = Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (Int32.Parse(volbaKonec) == 1)
            {
                Main();
            }
            else if (Int32.Parse(volbaKonec) == 2)
            {
                return;
            }
        }
        //done
        static public void InsertSort()
        {
            Console.Clear();
            string temp;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vítej v sekci Insert Sortu. Zde máš možnosti:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zde zadej číslo procesu, který by si chtěl spustit: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            temp = Console.ReadLine();
            while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < 1 || Int32.Parse(temp) > 3))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste číslo. Zvolte jednu ze zobrazených možností:\n\t1) Vyřešení uživatelem zadané pole \n\t2) Vysvětlení\n\t3) Zpět na start\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                temp = Console.ReadLine();
                Console.Clear();
            }
            switch (temp)
            {
                case "1":
                    VyreseniInsertSortu();
                    break;
                case "2":
                    VysvetleniInsertSortu();
                    break;
                case "3":
                    Console.Clear();
                    Main();
                    break;
                default:
                    break;
            }
        }
        //done
        static public void VyreseniInsertSortu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Zadej velikost pole: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string vel = Console.ReadLine();
            while (!Int32.TryParse(vel, out int number) || (Int32.Parse(vel) < -128 || Int32.Parse(vel) > 128))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                vel = Console.ReadLine();
                Console.Clear();
            }
            int[] pole = new int[Int32.Parse(vel)];
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Na indexu [{i}] vyplň číslo od -128 do 128: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out int number) || (Int32.Parse(temp) < -128 || Int32.Parse(temp) > 128))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od -128 do 128.\n\nProsím zkuste to znovu: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    temp = Console.ReadLine();
                    Console.Clear();
                }
                pole[i] = Int32.Parse(temp);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Chcete vidět postup?\n\t1) Ano\n\t2) Ne\n\nProsím zde zadejte hodnotu: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string videtPostup = Console.ReadLine();
            while (!Int32.TryParse(videtPostup, out int number) || (Int32.Parse(videtPostup) < 1 || Int32.Parse(videtPostup) > 2))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nezadali jste platné číslo. Zadejte prosím velikost od 1 do 2.\n\nProsím zkuste to znovu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                videtPostup = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            if (pole.Length <= 2)
            {
                if (pole.Length == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"[{pole[0]}]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (pole.Length == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"[{pole[0]}, {pole[1]}]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                for (int i = 0; i < pole.Length - 1; i++)
                {
                    int y = i + 1;
                    int tmp = pole[y];
                    while (y > 0 && tmp > pole[y - 1])
                    {
                        pole[y] = pole[y - 1];
                        y--;
                    }
                    pole[y] = tmp;
                    if (Int32.Parse(videtPostup) == 2)
                    {
                        if (i == 0 || i == pole.Length - 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            for (int x = 0; x < pole.Length - 1; x++)
                            {
                                if (x == 0)
                                {
                                    Console.Write("[");
                                }
                                Console.Write(pole[x] + ", ");
                                if (x == pole.Length - 2)
                                {
                                    Console.WriteLine(pole[x + 1] + "]");
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (Int32.Parse(videtPostup) == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        for (int x = 0; x < pole.Length - 1; x++)
                        {
                            if (x == 0)
                            {
                                Console.Write("[");
                            }
                            Console.Write(pole[x] + ", ");
                            if (x == pole.Length - 2)
                            {
                                Console.WriteLine(pole[x + 1] + "]");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string volbaKonec = Console.ReadLine();
                while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    volbaKonec = Console.ReadLine();
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (Int32.Parse(volbaKonec) == 1)
                {
                    Console.Clear();
                    Main();
                }
                else if (Int32.Parse(volbaKonec) == 2)
                {
                    return;
                }
            }
        //done
        static public void VysvetleniInsertSortu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Řazení vkládáním, známý jako insertion sort, je jednoduchý řadicí algoritmus založený na porovnávání.\nAlgoritmus řazení vkládáním pracuje tak, že prochází prvky postupně a každý další nesetříděný prvek zařadí na správné místo do již setříděné posloupnosti.\nJe to jeden z nejrychlejších algoritmů s kvadratickou časovou složitostí.\nJe asymptoticky pomalejší než pokročilé algoritmy jako třeba rychlé řazení nebo řazení slučováním, ale má jiné výhody.\nPříklad:\n(3 2 8 7 6) // Zadání, prvek 3 je triviálně seřazen\n(3 2 8 7 6) // Vezmeme dvojku a vložíme jí na správné místo (tam už je)\n(3 2 8 7 6) // 8 vložíme na první místo, zbytek čísel posuneme\n(8 3 2 7 6) // 7 vložíme mezi 8 a 3, 3 a 2 posuneme\n(8 7 3 2 6) // 6 vložíme mezi 7 a 3, čísla 3 a 2 posuneme\n(8 7 6 3 2) // seřazeno");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nZmáčkni klávesu pro pokračování...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string volbaKonec = Console.ReadLine();
                while (!Int32.TryParse(volbaKonec, out int number) || (Int32.Parse(volbaKonec) < 1 || Int32.Parse(volbaKonec) > 2))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chcete přejít na začátek programu či ho ukončit?\n\t1) Přejít na začátek programu\n\t2) Ukončit program\n\nZde napište vaši volbu: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    volbaKonec = Console.ReadLine();
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (Int32.Parse(volbaKonec) == 1)
                {
                    Main();
                }
                else if (Int32.Parse(volbaKonec) == 2)
                {
                    return;
                }
            }
    }
}