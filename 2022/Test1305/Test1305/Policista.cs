using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1305
{
    class Policista
    {
    public static void VzitZvire(string clovek, string jmeno, string vek, string typ)
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
