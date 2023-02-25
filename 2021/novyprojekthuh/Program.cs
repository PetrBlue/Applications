using System;

namespace novyprojekthuh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš číslo svého pole");
            Random amogus = new Random();
            int vstup = int.Parse(Console.ReadLine());
            int impostor = 0;
            int[] sus = new int[vstup];
            Console.WriteLine(sus);
            for (int i = 0; i < sus.Length; i++)
            {
                sus[i] = amogus.Next(1, 100);
                Console.Write(sus[i]);
                impostor = impostor + sus[i];
                if(i < vstup)
                {
                    Console.Write(" + ");
                    if(i == vstup)
                    {
                        Console.Write(" = ");
                    }
                }
            }
            Console.Write(" =");
            Console.Write("\n" + "Výsledek je " + impostor);
        } 
    }
}
