using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiatori
{
    internal class Gladiator
    {
        public int utok; //1-100
        public int obrana; //1-100
        public int zivoty; //500
        public static int healAmount = 100;
        public Random rnd = new Random();
        public Gladiator()
        {
            this.utok = rnd.Next(1, 100); //random utok, od jedne do stovky
            this.obrana = rnd.Next(1, 100); //random obrańa, od jedne do stovky
            this.zivoty = 500; //zivoty, 500
        }
        //zautocis na opponenta
        public void Utok(int hrac1, int hrac2)
        {
            Program.listGladiatoru[hrac2].zivoty += Program.listGladiatoru[hrac2].obrana - Program.listGladiatoru[hrac1].utok;
        }
        //healne o heal amount
        public void Heal()
        {
            zivoty = 500;
        }
    }
}
