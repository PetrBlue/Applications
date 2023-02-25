using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosakon
{
    internal class Autobus : Vozidlo
    {
        public Autobus(int pocetKol, string znacka, string model) : base(pocetKol, znacka, model)
        {
            /*pocetKol = 6;
            znacka = "Tramvaj";
            model = "Nejstarsi";*/
        }
    }
}
