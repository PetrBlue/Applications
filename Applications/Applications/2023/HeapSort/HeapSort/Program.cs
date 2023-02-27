using System;

namespace HeapSort
{
    internal class Program
    {
        /**
 * Razeni haldou (sestupne)
 * @param array pole k serazeni
 */
        public static int[] array = { 5, 1, 6, 9, 8, 7, 6, 1, 2, 3 };
        public static void Main(string[] args)
        {
            Heapsort();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        public static void Heapsort()
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                RepairTop(array.Length - 1, i);
            }
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(0, i);
                RepairTop(i - 1, 0);
            }
        }

        /**
         * Umisti vrchol haldy na korektni misto v halde (opravi haldu)
         * @param array - pole k setrizeni
         * @param bottom - posledni index pole, na ktery se jeste smi sahnout
         * @param topIndex - index vrsku haldy
         */
        private static void RepairTop(int bottom, int topIndex)
        {
            int tmp = array[topIndex];
            int succ = topIndex * 2 + 1;
            if (succ < bottom && array[succ] > array[succ + 1]) succ++;

            while (succ <= bottom && tmp > array[succ])
            {
                array[topIndex] = array[succ];
                topIndex = succ;
                succ = succ * 2 + 1;
                if (succ < bottom && array[succ] > array[succ + 1]) succ++;
            }
            array[topIndex] = tmp;
        }

        /**
         * Prohodi prvky v zadanem poli
         * @param array pole
         * @param left prvek 1
         * @param right prvek 2
         */
        private static void Swap(int left, int right)
        {
            int tmp = array[right];
            array[right] = array[left];
            array[left] = tmp;
        }

        //static int vel = 10;
        //static int[] array = { 5, 1, 6, 9, 8, 7, 6, 1, 2, 3 };
        //static void Main(string[] args)
        //{
        //    Heapify(vel);
        //    for (int i = vel - 1; i > 1; i--)
        //    {
        //        Swap(0, 1);
        //        Heapify(i);
        //    }
        //    Swap(0, 1);
        //    for (int i = 0; i < vel; i++)
        //    {
        //        Console.Write(array[i]);
        //        if (i != vel - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //    }
        //}
        //static void Heapify(int left)
        //{
        //    for (int i = 0; i < (left - 1) / 2; i++)
        //    {
        //        if (array[i] < array[2 * i + 1])
        //        {
        //            Swap(i, 2 * i + 1);
        //            i = (i - 1) / 2 - 1;
        //        }
        //        else if (left % 2 != 0 || i != (left - 1) / 2)
        //        {S
        //            if (array[i] < array[2 * i + 2])
        //            {
        //                Swap(i, 2 * i + 2);
        //                i = (i - 1) / 2 - 1;
        //            }
        //        }
        //    }
        //}
        //static void Swap(int x, int y)
        //{
        //    int temp = array[x];
        //    array[x] = array[y];
        //    array[y] = temp;
        //}
    }
}