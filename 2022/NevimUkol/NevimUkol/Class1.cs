using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevimUkol
{
    class Zak
    {
        public static void ZadejUkol()
        {
            string[] zaci = { "K", "T", "P", "V", "O", "L", "Y", "Q", "W", "E" };
            int[] ukoly = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] temp = {1,2,3,4,5,6,7,8};
            Random rnd = new Random();
            for (int i = 0; i < zaci.Length; i++)
            {
                loop:
                int temp2 = rnd.Next(1, 9);
                for(int j = 0; j < 8; j++)
                {
                    if (temp[j] == temp2)
                    {
                        ukoly[i] = temp[j];
                        temp[j] = 0;
                    }
                }
                if (i < 8)
                {
                    if (ukoly[i] == 0)
                    {
                        goto loop;
                    }
                    Console.WriteLine("Jméno: {0} Úkol: {1}", zaci[i], ukoly[i]);
                }
                else
                {
                    Console.WriteLine("Jméno: {0} Úkol: není přiřazen", zaci[i]);
                }
            }
        }
    }
}
