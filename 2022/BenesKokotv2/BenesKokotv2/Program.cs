using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenesKokotv2
{
    class Program
    {
        static void Main(string[] args)
        {
                int vel;
                String X = " \u2588";    //plny znak
                String Y = " \u2591";    //jakoby mezera (mezera je uzka)

                Console.Write("Zadej velikost:");
                vel = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("------ctverec--------------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                Console.WriteLine("------obdelnik1------------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 2 * vel; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------obdelnik2------------");
                for (int i = 0; i < 3 * vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik1----------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik2---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel - i; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik3---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                Console.WriteLine("------trojuhelnik4---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik5---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i < vel; i++)
                {
                    for (int j = 0; j < vel; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik6---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i < vel; i++)
                {
                    for (int j = 0; j < vel - i; j++)
                    {
                        Console.Write(X);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik7---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel + i; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------trojuhelnik8---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 2 * vel - i - 1; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------kosoctverec1--------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < vel + i; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------kosoctverec2--------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 2 * vel - i - 1; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------kosodelnik1---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 2 * vel + i - 1; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------kosodelnik2---------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 3 * vel - i - 2; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------lichobeznik1--------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 2 * vel + i - 1; j++)
                    {
                        if (i + j < vel - 1)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------lichobeznik2--------");
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 3 * vel - i - 2; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------kruh----------------");
                for (int i = 1; i < 2 * vel; i++)
                {
                    for (int j = 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------pulkruh1------------");
                for (int i = 1; i < vel; i++)
                {
                    for (int j = 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------pulkruh2------------");
                for (int i = 1; i < 2 * vel; i++)
                {
                    for (int j = 1; j < vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------pulkruh3------------");
                for (int i = vel + 1; i < 2 * vel; i++)
                {
                    for (int j = 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------pulkruh4------------");
                for (int i = 1; i < 2 * vel; i++)
                {
                    for (int j = vel + 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------ctvrtkruh1----------");
                for (int i = 1; i < vel; i++)
                {
                    for (int j = 1; j < vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------ctvrtkruh2----------");
                for (int i = 1; i < vel; i++)
                {
                    for (int j = vel + 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------ctvrtkruh3----------");
                for (int i = vel + 1; i < 2 * vel; i++)
                {
                    for (int j = 1; j < vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                Console.WriteLine("------ctvrtkruh4----------");
                for (int i = vel + 1; i < 2 * vel; i++)
                {
                    for (int j = vel + 1; j < 2 * vel; j++)
                    {
                        if ((i - vel) * (i - vel) + (j - vel) * (j - vel) <= (vel) * (vel))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("------parnik--------------");
                //------kominy--------------
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 13 * vel / 4; j++)
                    {
                        if (((j >= 7 * vel / 4) && (j < 9 * vel / 4)) || (j >= 11 * vel / 4))
                        {
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                //------kajuty--------------
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 15 * vel / 4 + i - 1; j++)
                    {
                        if (i + j < 3 * vel / 2 - 1)
                        {   //i+j-vel/2<vel-1 nebo i+j<vel-1+vel/2
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                //------podpalubi-----------
                for (int i = 0; i < vel; i++)
                {
                    for (int j = 0; j < 5 * vel - i; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(Y);
                        }
                        else
                        {
                            Console.Write(X);
                        }
                    }
                    Console.WriteLine();
                }
                //------koleso--------------
                for (int i = 1; i < vel; i++)
                { //(int i=vel+2;i<2*vel;i++){
                    for (int j = 0; j < 4 * vel; j++)
                    {
                        if ((i * i) + (j - 5 * vel / 2) * (j - 5 * vel / 2) <= (vel) * (vel))
                        {  //((i-vel)*(i-vel)+(j-5*vel/2)*(j-5*vel/2)<=(vel)*(vel)){
                            Console.Write(X);
                        }
                        else
                        {
                            Console.Write(Y);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
