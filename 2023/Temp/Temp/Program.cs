using System;

namespace Temp
{
    internal class Program
    {
        //D)
        //    x + y + z = x × y × z
        //    2x + 2y + 2z = a
        //    a = ?
        //    to půjde přes Brute Force
        //    3^3 kombinaci; 27
        //    Napíšu si na to c sharp program😆
        //    D)
        //    a) vypis 111 až 999; s tím že každá cifra je samostatná
        //    b) zkontroluj
        //    c) vypis všechny možné způsoby od -100 do 100
        //    d) zkontroluj
        //    e) for(c; c×10; c++){
        //       d)
        //    }
        static void Main(string[] args)
        {
            int start = -100;
            int end = 100;
            for (int i = start; i < end; i++)
            {
                for(int j = start; j < end; j++)
                {
                    for(int k = start; k < end; k++)
                    {
                        if(i + j + k == i * j * k)
                        {
                            Console.WriteLine($"{i} | {j} | {k}");
                        }
                        //Console.WriteLine($"{i} | {j} | {k}");
                    }
                }
            }
        }
    }
}