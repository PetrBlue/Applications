using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pizzerie
{
    internal class Skladiste
    {
        static public int koreni, sunka, testo, eidam, gouda, parmazan, niva, protlak, smetana;
        public int mouka, voda, drozdi, sul;
        static public List<string> Sklads = new List<string> { "koreni", "sunka", "eidam", "gouda", "parmazan", "niva", "protlak", "smetana", "mouka", "voda", "drozdi", "sul"};
        public static List<Ingredience> dostupneIngredience = new List<Ingredience>();
        public Skladiste()
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
            drozdi = 1000;
            sul = 2000;
        }
        static public void VygenerujSuroviny()
        {
            Console.Clear();
            Random rnd = new Random();
            for(int i = 0; i < Sklads.Count; i++)
            {
                dostupneIngredience.Add(new Ingredience(Sklads[i], rnd.Next(500, 5000)));
            }
        }
        static public void VypisSuroviny()
        {
            Console.Clear();
            foreach(var item in dostupneIngredience)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{item.nazev} - {item.mnozstvi}g/ml");
            }
        }
        static public void PridejSuroviny(int pocet)
        {
            Console.Clear();
            foreach (var item in dostupneIngredience)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"V {item.nazev} je {item.mnozstvi}g/ml");
                item.mnozstvi += pocet;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Do {item.nazev} bylo přidáno {pocet}, nové množství je {item.mnozstvi}g/ml");
            }
        }
    }
}
