using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1305
{
    class Veterinar
    {
        static Random rnd = new Random();
        public static void osetriZvire(string clovek, string jmeno, string vek, string typ)
        {
            if(clovek == "Kuba")
            {
                int sance = rnd.Next(0, 2);
                if (sance == 1)
                {
                    int temp = rnd.Next(500, 2501);
                    if (Clovek.penizeKuba > temp)
                    {
                        Clovek.penizeKuba -= temp;
                    }
                    else
                    {
                        Policista.VzitZvire(clovek, jmeno, vek, typ);
                    }
                }
                else
                {
                    for(int i = 0; i < Mazlicek.jmenoMazlickuKuba.Count; i++)
                    {
                        if(Mazlicek.jmenoMazlickuKuba[i] == jmeno)
                        {
                            Mazlicek.jmenoMazlickuKuba.RemoveAt(i);
                            Mazlicek.vekMazlickuKuba.RemoveAt(i);
                            Mazlicek.typMazlickuKuba.RemoveAt(i);
                        }
                    }
                }
            }
            else
            {
                int sance = rnd.Next(0, 2);
                if (sance == 1)
                {
                    int temp = rnd.Next(500, 2501);
                    if (Clovek.penizeHonza > temp)
                    {
                        Clovek.penizeHonza -= temp;
                    }
                    else
                    {
                        Policista.VzitZvire(clovek, jmeno, vek, typ);
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
}
