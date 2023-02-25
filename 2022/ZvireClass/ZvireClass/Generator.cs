using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvireClass
{
    internal class Generator
    {
        protected int pocetNohou;
        public int PocetNohou { get { return pocetNohou; } private set { } }
        public Generator(int nohy)
        {
            pocetNohou = nohy;
        }
    }
}