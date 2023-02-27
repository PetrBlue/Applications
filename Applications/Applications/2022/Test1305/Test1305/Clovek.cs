using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test1305
{
    class Clovek
    {
        public static string jmenoHonza = "Honza";
        public static int penizeHonza = 10000;
        public static List<int> seznamMazlickuHonza = new List<int>();
        public static string jmenoKuba = "Kuba";
        public static int penizeKuba = 10000;
        public static List<int> seznamMazlickuKuba = new List<int>();
        public static Random rnd = new Random();
        public static void priradMazlicka()
        {
            hcz:
            Console.WriteLine("Jsi Honza či Kuba?");
            string rozpoznaniCloveka = Console.ReadLine();
            if (rozpoznaniCloveka == "Honza" || rozpoznaniCloveka == "Kuba")
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Jak chceš aby se zvíře jmenovalo?");
                string jmenoZvirete = Console.ReadLine();
                Thread.Sleep(500);
                Console.Clear();
                vyber:
                Console.WriteLine("Co chceš za zvíře? Možnosti: Kočka, Pes, Křeček");
                string typZvirete = Console.ReadLine();
                int vek = rnd.Next(0, 16);
                if(typZvirete == "Kočka" || typZvirete == "Pes" || typZvirete == "Křeček")
                {
                    string temp = "Kuba";
                    if(rozpoznaniCloveka == "Honza")
                    {
                        temp = "Honza";
                    }
                    Mazlicek.vytvorMazlicka(temp, vek, jmenoZvirete, 4, typZvirete);
                }
                else
                {
                    Console.WriteLine("Prosím zadejte jedno ze tří typů zvířat: Kočka, Pes, Křeček");
                    Thread.Sleep(2500);
                    goto vyber;
                }
            }
            else
            {
                Console.WriteLine("Prosím zadejte jedno ze dvou jmen: Honza, Kuba");
                Thread.Sleep(2500);
                goto hcz;
            }

        }
        public static void odeberZvire(string clovek, string jmeno, string vek, string typ)
        {
                if (clovek == "Kuba")
                {
                        for (int i = 0; i < Mazlicek.jmenoMazlickuKuba.Count; i++)
                        {
                            if (Mazlicek.jmenoMazlickuKuba[i] == jmeno)
                            {
                                Mazlicek.jmenoMazlickuKuba.RemoveAt(i);
                                Mazlicek.vekMazlickuKuba.RemoveAt(i);
                                Mazlicek.typMazlickuKuba.RemoveAt(i);
                            }
                        }
                }
                else
                {
                    for (int i = 0; i < Mazlicek.jmenoMazlickuHonza.Count; i++)
                    {
                        if (Mazlicek.jmenoMazlickuHonza[i] == jmeno)
                        {
                            Mazlicek.jmenoMazlickuHonza.RemoveAt(i);
                            Mazlicek.vekMazlickuHonza.RemoveAt(i);
                            Mazlicek.typMazlickuHonza.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
