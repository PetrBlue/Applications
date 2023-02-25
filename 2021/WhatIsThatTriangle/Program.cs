using System;

namespace WhatIsThatTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš stranu a");
            Console.ForegroundColor = ConsoleColor.White;
            int a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš stranu b");
            Console.ForegroundColor = ConsoleColor.White;
            int b = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš stranu c");
            Console.ForegroundColor = ConsoleColor.White;
            int c = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatné Číslo! \n Toto  není trojúhelník! " + "(Rozměry: a = " + a + "cm b = " + b + "cm c = " + c + ")");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a == b && b == c && c == a)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Toto je rovnostranný trojúhelník :P " + "(Rozměry: a = " + a + "cm b = " + b + "cm c = " + c + ")");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (a == b || b == c || c == a)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Toto je rovnoramenný trojúhelník :P " + "(Rozměry: a = " + a + "cm b = " + b + "cm c = " + c + ")");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Toto je pravoúhlý trojúhelník :P " + "(Rozměry: a = " + a + "cm b = " + b + "cm c = " + c + ")");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Toto je normální trojúhelník :P " + "(Rozměry: a = " + a + "cm b = " + b + "cm c = " + c + ")");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
