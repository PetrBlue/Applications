using System;

namespace TurnajGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Random rnd = new Random();
            string[] hraci2 = new string[2];
            string[] hraci4 = new string[4];
            string[] hraci8 = new string[8];
            string[] hraci16 = new string[16];
            string[] hraci32 = new string[32];
            Console.WriteLine("Vítejte v aplikaci Turnaj Generátor");
            Console.WriteLine("Kolik hráčů hraje? \r\n Možnosti: 4,8,16,32.");
            switch (Console.ReadLine())
            {
                case "4":
                    goto ctyriHraci; 
                case "8":
                    goto osmHracu;
                case "16":
                    goto sestnactHracu;
                case "32":
                    goto tricetdvaHracu;
                default:
                    goto start;
            }
        ctyriHraci:
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Kdo hraje?");
                hraci4[i] = Console.ReadLine();
            }
            int match1 = rnd.Next(hraci4.Length);
            Console.WriteLine("{0}", hraci4[match1]);
            int match2 = rnd.Next(hraci4.Length);
            Console.WriteLine("{0}", hraci4[match2]);
            return;
        osmHracu:
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Kdo hraje?");
                hraci8[i] = Console.ReadLine();
            }
            
            return;
        sestnactHracu:
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("Kdo hraje?");
                hraci16[i] = Console.ReadLine();
            }
            return;
        tricetdvaHracu:
                for(int i = 0; i < 32; i++)
            {
                Console.WriteLine("Kdo hraje?");
                hraci32[i] = Console.ReadLine();
            }
            return;
        }
    }
}
