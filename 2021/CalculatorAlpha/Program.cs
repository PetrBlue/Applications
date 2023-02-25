using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i < 100; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("[" + 1 + "]" + "[" + j + "]");
                }
            }
        }
    }
}