using System;

namespace InterfaceFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fucking World!");
            Kocka kocka = new Kocka("kocicka");
            Pes pes = new Pes("pess");
            kocka.VydejZvuk();
            pes.VydejZvuk();
        }
    }
}
