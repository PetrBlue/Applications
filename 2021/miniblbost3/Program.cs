using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Hráč
        int hracZivoty = 100;
        int hracDMG = 10;

        //Prisera
        int priseraZivoty = 20;
        int priseraDMG = 20;

        //HRA
        bool hra = true;
        int volba = 0;

        while (hra == true)
        {
            if (hracZivoty =< 0)
            {
                hra = false;
            }
            if (priseraZivoty =< 0)
            {
                Console.WriteLine("ZABIL SI PŘÍŠERU!");
                Console.WriteLine("Objevil se kostlivec");
                priseraZivoty = 20;
            }

            while (hracZivoty > 0 && priseraZivoty > 0)
            {
                Console.WriteLine("Hráč \t  HP: " + hracZivoty + " DMG: " + hracDMG);
                Console.Writeline("Příšera \t HP: " + priseraZivoty + " DMG: " + priseraDMG);
                Console.WriteLine("\n\t1) útok");
                volba = Int32.Parse(Console.ReadLine());
                if (volba == 1)
                {
                    priseraZivoty -= hracDMG;
                }
                else
                {
                    Console.WriteLine("Špatná volba");
                }
            }
        }
    }

}
}