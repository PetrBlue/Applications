using System;
namespace autoPujcovna
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> listAuticek = new List<Auto>();
            listAuticek.Add(new Auto(4, "Ne", "Ano"));
            listAuticek.Add(new Auto(4, "Ano", "Ne"));
            autoPujc mojeAutopujcovna = new autoPujc("Pixa", "Pixov", listAuticek);
            autoPujc mojeAutopujcovna2 = new autoPujc("Pixa2", "Pixov2", listAuticek);
            Console.WriteLine("AHoj, vyber autocisuj: Mame:");
            mojeAutopujcovna.VypisAutopujcoven();
            mojeAutopujcovna2.VypisAutopujcoven();
            int cislo = int.Parse(Console.ReadLine());
            if(cislo == 1)
            {
                mojeAutopujcovna.VypisAuta();
            }
            if (cislo == 2)
            {
                mojeAutopujcovna2.VypisAuta();
            }
        }
    }
}