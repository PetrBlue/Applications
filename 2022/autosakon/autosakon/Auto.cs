using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosakon
{
    internal class Auto : Vozidlo
    {
        public Auto(int pocetKol, string znacka, string model) : base(pocetKol, znacka, model)
        {
            /*pocetKol = 4;
            znacka = "Skoda";
            model = "Nejnovejsi";*/
        }
    }
}
