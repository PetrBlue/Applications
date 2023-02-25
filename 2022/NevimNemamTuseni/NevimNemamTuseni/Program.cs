using System;

namespace NevimNemamTuseni
{
    class Program
    {
        class Privitani
        {
            public int vek;
            public string prijmeni;
            public string jmeno;
            static void Main(string[] args)
            {
                Privitani tomas = new Privitani("Tomáš", "Grisa", 99);
            }
            public Privitani(string jmeno, string prijmeni, int vek)
            {
                this.jmeno = jmeno;
                this.prijmeni = prijmeni;
                this.vek = vek;
            }
            public void ZmenaJmena(string j, string p)
            {
                jmeno = j;
                prijmeni = p;
            }
            public int ZiskejVek()
            {
                return vek;
            }
            public Privitani ZiskejObjekt(Privitani p)
            {
                return p;
            }
        }
    }
}
