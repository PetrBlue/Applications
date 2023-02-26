using System;

namespace AlgoritmizaceZelviGrafika
{
    class Program
    {
        static int smer = 0;
        static int uheli = 1;
        static int uhelj = 1;
        static int i = 0;
        static int j = 0;
        static int pomocna = 0;
        static int v;
        static string[,] pole;
        static void Main()
        {
            vypln();
            for (int k = 0; k < (v / 4) - 1; k++)
            {
                // otoc(směr{1,-3 = pravo|-1,3 = levo|2,-2 = otocka})
                // kresli1(kolikrat,pen,šikmo{false[smer 1 = smer 1],true[smer 1 = smer 1.5]})
                // kresli2() {dá barvu přimo podsebe/dodělá šikmou čáru pod větším úhlem}
                // proměná uheli a uhelj {určí o kolik políček se při kresli(_,_,true) posune po i/j souřadnicí}
                // zadej kód zde

                i = v - 1 - (2 * v / 3);
                j = v - 1 - (2 * v / 3);
                smer = 1;
                for(int l = 0; l < 4; l++)
                {
                    kresli1(v / 3, true, false);
                    otoc(1);
                }

            }
            for (int k = 0; k < v; k++)
            {
                for (int l = 0; l < v; l++)
                {
                    Console.Write(pole[k, l]);
                }
                Console.WriteLine();
            }

        }
        static void vypln()
        {
            Console.WriteLine("zadej velikost:");
            v = Int32.Parse(Console.ReadLine());
            pole = new string[v, v];
            for (int i2 = 0; i2 < v; i2++)
            {
                for (int j2 = 0; j2 < v; j2++)
                {
                    pole[i2, j2] = "\u2591\u2591";
                }
            }
        }
        static void otoc(int směr)
        {
            smer = (smer + směr + 4) % 4;
        }
        static void kresli1(int kolikrat, bool on, bool šikmo)
        {
            int i2 = 0;
            int j2 = 0;
            if (smer == 0 && šikmo == false)
            {
                i2 = -1;
            }
            else if (smer == 1 && šikmo == false)
            {
                j2 = 1;
            }
            else if (smer == 2 && šikmo == false)
            {
                i2 = 1;
            }
            else if (smer == 3 && šikmo == false)
            {
                j2 = -1;
            }
            else if (smer == 0)
            {
                i2 = -uheli;
                j2 = uhelj;
            }
            else if (smer == 1)
            {
                j2 = uhelj;
                i2 = uheli;
            }
            else if (smer == 2)
            {
                i2 = uheli;
                j2 = -uhelj;
            }
            else if (smer == 3)
            {
                j2 = -uhelj;
                i2 = -uheli;
            }
            for (int k = 0; k < kolikrat; k++)
            {
                if (on == true)
                {
                    kresli2();
                }
                i = i + i2;
                j = j + j2;
            }
        }
        static void kresli2()
        {


            for (int l = 0; l < uheli + uhelj - 1; l++)
            {
                if (uheli > 1 && i + l < v)
                {
                    pole[i + l, j] = "\u2588\u2588";
                }
                else if (uhelj > 1 && j + l < v)
                {
                    pole[i, j + l] = "\u2588\u2588";
                }
                else if (j < v && i < v)
                {
                    pole[i, j] = "\u2588\u2588";
                }
            }

        }






        /*static public int i = 0;
        static public int j = 0;
        static public int temp = 0;
        static public int[,] pole;
        static public int smer = 0;
        static void Main()
        {
            Prazdne(Int32.Parse(Console.ReadLine()));

            for (int k = 0; k < pole.Length; k++)
            {
                for (int l = 0; l < pole.Length; l++)
                {
                    Console.Write(pole[k,l]);
                }
                Console.WriteLine();
            }
        }
        static void Kresli(int kolik, bool pen)
        {

        }
        static void Prazdne(int vel)
        {
            pole = new int[vel, vel];
            for (int k = 0; k < vel; k++)
            {
                for (int l = 0; l < vel; l++)
                {
                    pole[k, l] = '\u2591';
                }
            }
        }
        static void otoc(bool pravo)
        {

        }*/
    }
}
