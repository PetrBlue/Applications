using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SpiralAlgHw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            int vel = Convert.ToInt32(Console.ReadLine());
            int[,] pole = new int[vel, vel];

            

            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    Console.Write(pole[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();



























            /*
            Console.Write("Zadej číslo: ");
            int vel = Convert.ToInt32(Console.ReadLine());
            int[,] pole = new int[vel, vel];
            int temp = 1;
            int x = 0;
            int y = vel - 1;
            while (temp <= vel * vel)
            {
                //right
                for (int i = x; i <= y; i++)
                    pole[x, i] = temp++;
                //down
                for (int j = x + 1; j <= y; j++)
                    pole[j, y] = temp++;
                //left
                for (int i = y - 1; i >= x; i--)
                    pole[y, i] = temp++;
                //up 
                for (int j = y - 1; j >= x + 1; j--)
                    pole[j, x] = temp++;
                x++;
                y--;
            }
            for (int i = 0; i < vel; i++)
            {
                for (int j = 0; j < vel; j++)
                {
                    Console.Write(pole[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }*/
            /*public static void lol()
            {
                Console.WriteLine("WELCOME\n WHAT OUR INPUT!");
                //this GET the user input
                string input = Console.ReadLine();
                //this is the arry that will output the big numbers but i just put it as a letters as a test
                //we all know that arry start from 0 then 1 then 2 and more
                string[] big_NUMBERS = { "H", "U", "K", "Y", "O", "S" };
                //this will count the input like example: Hello = 4 , hi = 2 so it counts each letters
                int input_length = input.Length;

                //like let use While loop so we dont have to write like 7000 lines
                //
                //so let check if the user put something in the input
                if (input_length > 0)
                {
                    //now let use the while loop so if input_length is big than 0 it will keep going 
                    //let make a string that will hold the input first
                    string input_holder = "";
                    while (input_length > 0)
                    {
                        while (input_holder != Convert.ToString(input.Length))
                        {
                            if (input.Contains("1"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[0]);
                            }
                            if (input.Contains("2"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[1]);
                            }
                            if (input.Contains("3"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[2]);

                            }
                            if (input.Contains("4"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[3]);

                            }
                            if (input.Contains("5"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[4]);

                            }
                            if (input.Contains("6"))
                            {
                                input_holder += Convert.ToString(big_NUMBERS[5]);

                            }
                        }
                        Console.WriteLine(input_holder);
                        input_length -= input_holder.Length;
                    }
                    {

                    }

                }
            }*/
        }
    }
}
