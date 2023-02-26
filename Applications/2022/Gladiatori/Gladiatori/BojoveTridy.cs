using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiatori
{
    internal class BojoveTridy
    {
        public BojoveTridy()
        {

        }
    }
    internal class Bojovnik : Gladiator
    {
        public Bojovnik()
        {
            this.utok = rnd.Next(1, 10); //random utok, od jedne do stovky
            this.obrana = rnd.Next(1, 10); //random obrańa, od jedne do stovky
            this.zivoty = 5000; //zivoty, 500
        }
    }
    internal class Lucisnik : Gladiator
    {
        public Lucisnik()
        {
            this.utok = rnd.Next(1, 50); //random utok, od jedne do stovky
            this.obrana = rnd.Next(50, 150); //random obrańa, od jedne do stovky
            this.zivoty = 1000; //zivoty, 500
        }
    }
    internal class Mag : Gladiator
    {
        public Mag()
        {
            this.utok = rnd.Next(200, 300); //random utok, od jedne do stovky
            this.obrana = rnd.Next(1, 200); //random obrańa, od jedne do stovky
            this.zivoty = 300; //zivoty, 500
        }
    }
    internal class Tank : Gladiator
    {
        public Tank()
        {
            this.utok = rnd.Next(1, 50); //random utok, od jedne do stovky
            this.obrana = 0; //random obrańa, od jedne do stovky
            this.zivoty = 10000; //zivoty, 500
        }
    }
    internal class Vrah : Gladiator
    {
        public Vrah()
        {
            this.utok = rnd.Next(100, 500); //random utok, od jedne do stovky
            this.obrana = rnd.Next(50, 150); //random obrańa, od jedne do stovky
            this.zivoty = 50; //zivoty, 500
        }
    }
}
