using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoPujcovna
{
    internal class Auto
    {
        public int pocetKol;
        public string znacka, model;
        public Auto(int pocetKol, string znacka, string model)
        {
            this.pocetKol = pocetKol;
            this.znacka = znacka;
            this.model = model;
        }
    }
}
