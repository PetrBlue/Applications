using System;

namespace MartinProjekt
{
    class Program
    {
            public static Random rnd = new Random();

            static void Main(string[] args)
            {
                string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] poleAbeceda = abeceda.ToLower().ToCharArray();
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < rnd.Next(4, poleAbeceda.Length - 1); i++)
                    {
                        Console.Write(poleAbeceda[rnd.Next(i, poleAbeceda.Length - 1)]);
                    }
                    Console.WriteLine();
                }
                bool uhadl = true;
                int iterace = 0;
                string[] slova = { "pes", "kos", "ara", "oko", "bok", "bod", "les", "lol", "kus" };
                while (uhadl)
                {
                    string temp = "";
                    for (int i = 0; i < 3; i++)
                    {
                        temp += poleAbeceda[rnd.Next(0, poleAbeceda.Length - 1)];
                        Console.WriteLine(temp);
                        foreach (var item in slova)
                        {
                            if (item == temp)
                            {
                                Console.WriteLine("Slovo: " + item);
                                Console.WriteLine("Iterace: " + iterace);
                                uhadl = false;
                            }
                        }
                    }
                    //Console.WriteLine("Iterace: " + iterace);
                    iterace++;
                }
            }
        }
    }

