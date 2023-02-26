using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1305
{
    class Mazlicek
    {
        public static List<string> jmenoMazlickuHonza = new List<string>();
        public static List<string> jmenoMazlickuKuba = new List<string>();
        public static List<string> typMazlickuKuba = new List<string>();
        public static List<int> vekMazlickuHonza = new List<int>();
        public static List<int> vekMazlickuKuba = new List<int>();
        public static List<string> typMazlickuHonza = new List<string>();
        public static int pocetNohou = 4;
        public static string[] typ = { "Kočka", "Pes", "Křeček" };
        public static void vytvorMazlicka(string clovek, int vek, string jmeno, int pocetNohou, string typ)
        {
            if (clovek == "Honza")
            {
                vekMazlickuHonza.Add(vek);
                jmenoMazlickuHonza.Add(jmeno);
                typMazlickuHonza.Add(typ);
            }
            else if (clovek == "Kuba")
            {
                vekMazlickuKuba.Add(vek);
                jmenoMazlickuKuba.Add(jmeno);
                typMazlickuKuba.Add(typ);
            }
            else
            {
                Console.WriteLine("Špatné jméno, tento člověk není v seznamu");
            }
        }
    }
}
