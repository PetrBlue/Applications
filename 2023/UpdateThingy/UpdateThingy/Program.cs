using System;
using System.Threading;

namespace UpdateThingy
{
    public class Program
    {
        public static int percentage = 0; /*0 - 100*/
        public static string full = "\u2588";
        public static string empty = "▓";
        public static void Main(string[] args)
        {
            Update();
        }
        public static void Update()
        {
            int temp = percentage / 10;
            for(int i = 1; i <= 10; i++)
            {
               if(i <= temp)
               {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(full);
               }
               else
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(empty);
               }
            }
            Console.WriteLine();
            percentage++;
            Thread.Sleep(100);
            Console.Clear();
            Update();
        }
    }
}
//▇▇▇▇▇░░░░░▪

/*
 * ╔══════════════
 * ║▇▇▇▇▇░░░░░▪
 * ╚══════════════
 */

/*  ▁▁▁▁▁▁▁
 *  ▇▇▇▇▇░░░░░▪
 *  ▔▔▔▔▔▔▔
 */