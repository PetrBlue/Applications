using System;

namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartApp();
        }
        static void StartApp()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Hey bish, chci velikost poleeee: ");
            int vel = Int32.Parse(Console.ReadLine());
            int[] array = FillArray(new int[vel]);
            array = Quicksort(array, 0, vel);
            Console.WriteLine("Done");
            VypisArray(array);
        }
        static int[] Quicksort(int[] array, int left, int right)
        {
            if (left >= right) return array;
            int boundary = left;
            for(int i = left+1; i < right; i++)
            {
                if (array[i] < array[left])
                {
                    array = Swap(array, i, ++boundary);
                }
            }
            array = Swap(array, left, boundary);
            array = Quicksort(array, left, boundary);
            array = Quicksort(array, boundary + 1, right);
            return array;
        }
        static int[] Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
            return array;
        }
        static int[] FillArray(int[] array)
        {
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 11);
            }
            return array;
        }
        static void VypisArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}