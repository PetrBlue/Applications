using System;

namespace miniblbost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hráč
            int hracZivoty = 100;
            int hracDMG = 10;

            //Příšera
            int priseraZivoty = 20;
            int priseraDMG = 20;

            //HRA
            bool hra = true;

            while (hra == true) {
                if (hracZivoty¨=< 0){
                    hra = false;
                }
                if (priseraZivoty =< 0) {
                    Console.WriteLine("Příšera byla poražena");
                    Console.WriteLine("Objevil se kostlivec");
                    priseraZivoty = 20;
                }
                while(hracZivoty > 0  priseraZivoty > 0){
                    Console.WriteLine("Hráč \t HP: " +)
                    Console.WriteLine
                }
                }
            }
        }
    }
}
