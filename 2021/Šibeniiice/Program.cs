using System;

namespace Šibeniiice
{
    class Program
    {
        static void Main(string[] args)
        {
            int chyba = 0;
            Random rnd = new Random();
            string[] poleHadanychSlov = {"Aneta"};
            for (int i = 0; i < poleHadanychSlov.Length; i++)
            {
                poleHadanychSlov[i].ToLower();
            }
            char[] vybraneSlovo = poleHadanychSlov[rnd.Next(0, poleHadanychSlov.Length - 1)].ToCharArray();
            bool gameIsRunning = true;

            // _
            char[] polePodtrzitko = new char[vybraneSlovo.Length];
            for (int i = 0; i < polePodtrzitko.Length; i++)
            {
                polePodtrzitko[i] = '_';
            }
            // game console
            while(gameIsRunning == true)
            {
                int count = 0;
                int pocetPodtrzitek = 0;
                Console.WriteLine();
                Console.WriteLine("Počet chyb: " + chyba + "\r\n");
                //Vypis do konzole
                for (int i = 0; i < vybraneSlovo.Length; i++)
                {
                    Console.Write("{0}", polePodtrzitko[i]);
                }

                Console.WriteLine("\r\n \r\n Zadejte hádané písmenko");
                char vstup = char.Parse(Console.ReadLine());


                //podminka
                for (int i = 0; i < vybraneSlovo.Length; i++)
                {
                    if(vybraneSlovo[i] == vstup)
                    {
                        polePodtrzitko[i] = vstup;
                        Console.Clear();
                        continue;
                    }
                    count++;
                    if(count == polePodtrzitko.Length)
                    {
                        Console.Clear();
                        chyba++;
                    }
                    if (polePodtrzitko[i].Equals('_'))
                    {
                        Console.WriteLine(pocetPodtrzitek);
                        pocetPodtrzitek++;
                        if (pocetPodtrzitek == 0)
                        {
                            Console.WriteLine("Nice vyhrál jsi");
                            Console.WriteLine("Měl jsi " + chyba + " chyb");
                            gameIsRunning = false;
                            return;
                        }
                    }
                    {
                        Console.WriteLine("Nice vyhrál jsi");
                        return;
                    }
                }
            }
            //TODO error check

            //TODO check win

        }
    }
}
