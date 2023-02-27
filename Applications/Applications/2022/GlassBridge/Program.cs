using System;

namespace GlassBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Napiš kolik chceš skel");
            int obtiznost = int.Parse(Console.ReadLine());
            int[] pole1 = new int[obtiznost];
            int[] pole2 = new int[obtiznost];
            //int zivoty = 3;

            for (int i = 0; i < obtiznost; i++)
            {
                /*if (zivoty == 0)
                {
                    Console.WriteLine("Prohrál jsi");
                    return;
                }*/
                //Console.WriteLine("Máš " + zivoty + " životy.");
                Console.WriteLine("Chceš jít doleva či doprava? \r\n 1) Doleva \r\n 2) Doprava");
                int volba = int.Parse(Console.ReadLine());
                pole1[i] = rnd.Next(0, 2);
                if (volba == 1 && pole1[i] == 1 || volba == 1 && pole2[i] == 0 || volba == 2 && pole2[i] == 1 || volba == 2 && pole1[i] == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Uhádl jsi to");
                    //zivoty++;
                }
                if (volba == 1 && pole1[i] == 0 || volba == 1 && pole2[i] == 1 || volba == 2 && pole1[i] == 1 || volba == 2 && pole2[i] == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Neuhádl jsi to, prohrál jsi");
                    return;
                    //zivoty--;
                }
                if (pole1[i] == 1)
                {
                    pole2[i] = 0;
                    Console.WriteLine("|" + pole1[i] + "|-|" + pole2[i] + "|");
                }
                if (pole1[i] == 0)
                {
                    pole2[i] = 1;
                    Console.WriteLine("|" + pole1[i] + "|-|" + pole2[i] + "|");
                }
            }
            Console.WriteLine("Vyhrál jsi!");
            for (int i = 0; i < obtiznost; i++)
            {
                Console.WriteLine("|" + pole1[i] + "|-|" + pole2[i] + "|");
            }
        } 
    }
}
