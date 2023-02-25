using System;

namespace Farmicka
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 Slepic
            //4 vajicka denne
            //po-ne
            //0-2 denne vajicek
            //4 vajicka na snidani, ano - odebrat 4 vajicka
            //pokud nedele vice jak 5 vajicek prodame jedno za 5 korun

            Random rnd = new Random();
            int vajicka = 0;
            int[] tyden = new int[7];
            int penize = 0;
            int slepicky = 5;
            //int jidlo = 0;
            int penizky = 0;
            for(int i = 0; i < 52; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    
                    if(vajicka > 4)
                    {
                        vajicka -= 4;
                    }
                    /*if(vajicka < 4)
                    {
                        if (jidlo == 0)
                        {
                            slepicky -= 1;
                            jidlo += 7;
                        }
                        if(jidlo > 0)
                        {
                            jidlo -= 1;
                        }
                    } */
                    int tmp = rnd.Next(0, 2) * slepicky;
                    vajicka += tmp;
                    tyden[j] += tmp;
                }
                if(vajicka >= 5)
                {
                    penize += vajicka * 5;
                    vajicka = 0;
                }
                if(penize >= 100)
                {
                    penizky = penize / 100;
                    slepicky += penizky;
                    penize -= penizky * 100;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Máš " + slepicky + " slepiček.");
            Console.WriteLine("Máš " + penize + " peněz");

            if(tyden[0] > tyden[1] && tyden[0] > tyden[2] && tyden[0] > tyden[3] && tyden[0] > tyden[4] && tyden[0] > tyden[5] && tyden[0] > tyden[6])
            {
                Console.WriteLine("Pondělí je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[1] > tyden[0] && tyden[1] > tyden[2] && tyden[1] > tyden[3] && tyden[1] > tyden[4] && tyden[1] > tyden[5] && tyden[1] > tyden[6])
            {
                Console.WriteLine("Úterý je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[2] > tyden[0] && tyden[2] > tyden[1] && tyden[2] > tyden[3] && tyden[2] > tyden[4] && tyden[2] > tyden[5] && tyden[2] > tyden[6])
            {
                Console.WriteLine("Středa je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[3] > tyden[1] && tyden[3] > tyden[2] && tyden[3] > tyden[0] && tyden[3] > tyden[4] && tyden[3] > tyden[5] && tyden[3] > tyden[6])
            {
                Console.WriteLine("Čtvrtek je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[4] > tyden[1] && tyden[4] > tyden[2] && tyden[4] > tyden[3] && tyden[4] > tyden[0] && tyden[4] > tyden[5] && tyden[4] > tyden[6])
            {
                Console.WriteLine("Pátek je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[5] > tyden[1] && tyden[5] > tyden[2] && tyden[5] > tyden[3] && tyden[5] > tyden[4] && tyden[5] > tyden[0] && tyden[5] > tyden[6])
            {
                Console.WriteLine("Sobota je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            if (tyden[6] > tyden[1] && tyden[6] > tyden[2] && tyden[6] > tyden[3] && tyden[6] > tyden[4] && tyden[6] > tyden[5] && tyden[6] > tyden[0])
            {
                Console.WriteLine("Neděle je nejproduktivnější den v týdnu s " + tyden[0] + " vajíčky.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
