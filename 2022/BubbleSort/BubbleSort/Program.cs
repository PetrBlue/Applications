using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];
            Random rnd = new Random();
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(0, 101);
            }
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1; j++)
                {
                    if(pole[j] > pole[j + 1])
                    {
                        int temp = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + ", ");
            }
        }
    }
}
