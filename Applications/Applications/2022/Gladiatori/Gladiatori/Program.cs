using System;

namespace Gladiatori
{
    internal class Program
    {
        public static List<Gladiator> listGladiatoru = new List<Gladiator>();
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Application();
        }
        public static void Application()
        {
            Console.WriteLine("Lol arena, za´biju se xddd");
            //input na kolik chces glads
            for(int i = 0; i < 4 /*userinput*/; i++)
            {
                Gladiator gladiator = new Gladiator();
                listGladiatoru.Add(gladiator);
            }
            Console.WriteLine("Souboj 1 vs 2");
            int x = Battle(0, 1);
            listGladiatoru[x].Heal();
            Console.WriteLine("Kdo vyhral? " + x);
            Console.WriteLine("Souboj 3 vs 4");
            int y = Battle(2, 3);
            listGladiatoru[y].Heal();
            Console.WriteLine("Kdo vyhral? " + y);
            int z = Battle(x, y);
            Console.WriteLine($"vyhral {z}");
        }
        static public int Battle(int hrac1, int hrac2)
        {
            while (listGladiatoru[hrac1].zivoty > 0 && listGladiatoru[hrac2].zivoty > 0)
            {
                int whoStarts = rnd.Next(1, 3);
                int whoPlays = 0; //1 = p1, 2 = p2, 0 = nezacalo se hrat
                if (whoPlays == 0)
                {
                    if (whoStarts == 1)
                    {
                        listGladiatoru[hrac1].Utok(hrac1, hrac2);
                        whoPlays = 2;
                    }
                    else
                    {
                        listGladiatoru[hrac2].Utok(hrac2, hrac1);
                        whoPlays = 1;
                    }
                }
                else
                {
                    if (whoPlays == 1)
                    {
                        listGladiatoru[hrac1].Utok(hrac1, hrac2);
                        whoPlays = 2;
                    }
                    else
                    {
                        listGladiatoru[hrac2].Utok(hrac2, hrac1);
                        whoPlays = 1;
                    }
                }
            }
            if (listGladiatoru[0].zivoty < 0)
            {
                return hrac2;
            }
            if (listGladiatoru[1].zivoty < 0)
            {
                return hrac1;
            }
            return -1;
        }
    }
}