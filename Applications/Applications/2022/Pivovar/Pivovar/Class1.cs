using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar
{
    internal class Pivovar
    {
        public static int c = 200;
        public static int v = 500;
        public static int s = 400;
        public static int k = 250;
        static bool SurovinyNaPivo()
        {
            if (Sklad.Chmel >= c && Sklad.Voda >= v && Sklad.Slad >= s && Sklad.Kvasnice >= k)
            {
                return true;
            }
            else
            {
                if (Sklad.Chmel < c)
                {
                    Console.WriteLine("Chybí nám chmel!");
                }
                if (Sklad.Voda < v)
                {
                    Console.WriteLine("Chybí nám voda!");
                }
                if (Sklad.Slad < s)
                {
                    Console.WriteLine("Chybí nám slad!");
                }
                if (Sklad.Kvasnice < k)
                {
                    Console.WriteLine("Chybí nám kvasnice!");
                }
                return false;
            }
        }
        public static void UvarPivo()
        {
            if (SurovinyNaPivo() == true)
            {
                Sklad.PridejPivo(c,v,s,k);
            }
        }
    }
}
