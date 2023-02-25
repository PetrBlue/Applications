using System;

namespace HadaniSlovicekxd
{
    class Program
        {
            static void Main(string[] args)
            { 
               Random random = new Random();
               string[] hadaneSlovo = { "ananas", "sus", "opice", "impostor", "laurosaurus", "crewmate", "pc", "noob" };
               string vybraneSlovo = hadaneSlovo[random.Next(0, hadaneSlovo.Length - 1)];
               int delkaSlova = vybraneSlovo.Length;
               int pocetChyb = 0;
               bool hrajeme = true;

                while (hrajeme)
                { 
                Console.WriteLine("Počet písmen k hádání " + delkaSlova);
                Console.WriteLine("Tvé hádané číslo: ");
                char pismenko = char.Parse (Console.ReadLine());
                if (vybraneSlovo.Contains(pismenko) && delkaSlova > 0)
                {
                    Console.WriteLine("Ez, trefil jsi to!");
                    delkaSlova--;
                }
                else if(delkaSlova == 0)
                {
                    Console.WriteLine("Vyhrál jsi borče!");
                    hrajeme = false;
                }
                else
                {
                    Console.WriteLine("Ty debile špatné písmenko");
                    pocetChyb++;
                }

                }
            }
       }
}
