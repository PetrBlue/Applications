using System;

namespace Pivovar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                for(int i = 0; i < rnd.Next(2,Hospoda.pocetLidi); i++)
                {
                    Pivovar.UvarPivo();
                }
                Hospoda.Nalejvarna();
            }
        }
    }
}
