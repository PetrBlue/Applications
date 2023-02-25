using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzerie
{
    internal class Skladiste
    {
        public int koreni, sunka, testo, eidam, gouda, parmazan, niva, protlak, smetana;
        public int mouka, voda, drozdi, sul;
        public List<string> Sklads = new List<string> { "koreni", "sunka", "eidam", "gouda", "parmazan", "niva", "protlak", "smetana", "mouka", "voda", "drozdi", "sul"};
        public static List<Ingredience> dostupneIngredience = new List<Ingredience>();
        public Skladiste(/*int koreni, int sunka, int testo, int eidam, int gouda, int parmazan, int niva, int protlak, int smetana*/)
        {
            koreni = 1000;
            sunka = 2000;
            eidam = 2000;
            gouda = 2000;
            parmazan = 2000;
            niva = 2000;
            protlak = 3000;
            smetana = 500;
            voda = 5000;
            mouka = 5000;
            drozdi = 0;
            sul = 0;
            VygenerujPotraviny();
        }
        public void VygenerujPotraviny()
        {
            Random rnd = new Random();
            for(int i = 0; i < Sklads.Count; i++)
            {
                dostupneIngredience.Add(new Ingredience(Sklads[i], rnd.Next(500, 5000)));
            }
        }
        public void VypisPotraviny()
        {
            foreach(var item in dostupneIngredience)
            {
                Console.WriteLine("{0} - {1}g/ml\n", item.nazev, item.mnozstvi);
            }
        }
    }
}
