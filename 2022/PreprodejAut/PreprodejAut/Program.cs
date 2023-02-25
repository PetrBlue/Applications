using System;

namespace PreprodejAut
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int penize = 0;

            for(int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(721291, 2219889);
                int barva = rnd.Next(1, 6);
                if (barva == 1)
                {
                    //cerna
                    penize -= temp;
                    penize += temp / 100 * 140;
                }
                if (barva == 2)
                {
                    //zluta
                    penize -= temp;
                    penize += temp / 100 * 105;
                }
                if (barva == 3)
                {
                    //cervena
                    penize -= temp;
                    penize += temp / 100 * 70;
                }
                if (barva == 4)
                {
                    //modra
                    penize -= temp;
                    penize += temp / 100 * 130;
                }
                if (barva == 5)
                {
                    //zelena
                    penize -= temp;
                    penize += temp / 100 * 60;
                }
            }
            Console.WriteLine(penize + "Kč");
        }
    }
}
