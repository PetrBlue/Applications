using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosakon
{
    internal class Vozidlo
    {
        protected int pocetKol;
        protected string znacka, model;

        public int PocetKol { get { return pocetKol; } private set { } }
        public Vozidlo(int pocetKol, string znacka, string model)
        {
            this.pocetKol = pocetKol;
            this.znacka = znacka;
            this.model = model;
        }
        public void VypisPocetKol()
        {
            Console.WriteLine($"Počet kol: {pocetKol}, Značka: {znacka}, Model: {model}");
        }
    }
}
