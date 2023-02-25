using System;

namespace Piškvorky
{
    class Program
    {
        static void Main(string[] args)
        {
            //Body hracu
            int bodyHrac1 = 0;
            int bodyHrac2 = 0;

            //9 poli piskvorek
            int pole1 = 0;
            int pole2 = 0;
            int pole3 = 0;
            int pole4 = 0;
            int pole5 = 0;
            int pole6 = 0;
            int pole7 = 0;
            int pole8 = 0;
            int pole9 = 0;
            bool hrac1 = false;
            bool hrac2 = false;

            //Herni Pole
            /*
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole1 + "|" + pole2 + "|" + pole3 + "|" + "              Příklad: | 1 | 2 | 3 |");
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole4 + "|" + pole5 + "|" + pole6 + "|" + "                       | 4 | 5 | 6 |");
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole7 + "|" + pole8 + "|" + pole9 + "|" + "                       | 7 | 8 | 9 |");
            Console.WriteLine("-------" + "                       -------------");
            */

            //Podminka na vyhru
            /* 
            if (pole1 == pole2 && pole2 == pole3 || pole1 == pole5 && pole5 == pole9 || pole1 == pole4 && pole4 == pole7 || pole3 == pole5 && pole5 == pole7 || pole3 == pole6 && pole6 == pole9 || pole7 == pole8 && pole8 == pole9 || pole2 == pole5 && pole5 == pole8 || pole4 == pole5 && pole5 == pole6)
            {
                Console.WriteLine("Konec Hry");
            } 
            */

            //Podminka na vyhru
            /*
              if(pole1 > 0 && pole2 > 0 && pole3 > 0 && pole4 > 0 && pole5 > 0 && pole6 > 0 && pole7 > 0 && pole8 > 0 && pole9 > 0)
            {
                if (pole1 == pole2 && pole2 == pole3)
                {
                    
                }
                if(pole1 == pole5 && pole5 == pole9)
                {

                }
                if(pole1 == pole4 && pole4 == pole7)
                { 

                }
                if(pole3 == pole5 && pole5 == pole7)
                {

                }
                if(pole3 == pole6 && pole6 == pole9)
                {

                }
                if(pole7 == pole8 && pole8 == pole9)
                {

                }
                if(pole2 == pole5 && pole5 == pole8)
                {

                }
                if(pole4 == pole5 && pole5 == pole6)
                {

                }
            }
            */

            //Podminka na vyhru verze 3
            /*
            if (pole1 == pole2 && pole2 == pole3)
            {
                if (pole1 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole1 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole1 == pole5 && pole5 == pole9)
            {
                if (pole1 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole1 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole1 == pole4 && pole4 == pole7)
            {
                if (pole1 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole1 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole3 == pole5 && pole5 == pole7)
            {
                if (pole3 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole3 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole3 == pole6 && pole6 == pole9)
            {
                if (pole3 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole3 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole7 == pole8 && pole8 == pole9)
            {
                if (pole7 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole7 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole2 == pole5 && pole5 == pole8)
            {
                if (pole2 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole2 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
            if (pole4 == pole5 && pole5 == pole6)
            {
                if (pole4 == 1)
                {
                    Console.WriteLine("Hráč 1 vyhrál!");
                }
                if (pole4 == 2)
                {
                    Console.WriteLine("Hráč 2 vyhrál!");
                }
            }
             */

            //Zacatek Hry
            zacatek:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vítejte u hry Piškvorky. \r\n \r\nKdo začíná? \r\n 1) Hráč 1 \r\n 2) Hráč 2");
            Console.ForegroundColor = ConsoleColor.White;
            int zacatek = int.Parse(Console.ReadLine());
            if(zacatek == 1)
            {
                hrac1 = true;
                hrac2 = true;
                goto hrac1;
            }
            if (zacatek == 2)
            {
                hrac1 = true;
                hrac2 = true;
                goto hrac2;
            }

        //Hra
        hrac1:
            if (hrac1 == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hráč 1 má " + bodyHrac1 + " bodů.");
                Console.WriteLine("Hráč 2 má " + bodyHrac2 + " bodů.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole1 + "|" + pole2 + "|" + pole3 + "|" + "              Příklad: | 1 | 2 | 3 |");
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole4 + "|" + pole5 + "|" + pole6 + "|" + "                       | 4 | 5 | 6 |");
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole7 + "|" + pole8 + "|" + pole9 + "|" + "                       | 7 | 8 | 9 |");
                Console.WriteLine("-------" + "                       -------------");
                Console.ForegroundColor = ConsoleColor.White;

                //Vyber Poli
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (pole1 > 0 && pole2 > 0 && pole3 > 0 && pole4 > 0 && pole5 > 0 && pole6 > 0 && pole7 > 0 && pole8 > 0 && pole9 > 0)
                {
                    Console.WriteLine("Remíza.");
                    pole1 = 0;
                    pole2 = 0;
                    pole3 = 0;
                    pole4 = 0;
                    pole5 = 0;
                    pole6 = 0;
                    pole7 = 0;
                    pole8 = 0;
                    pole9 = 0;
                    goto playAgain;
                }
                Console.WriteLine("Hráči 1, vyber si své pole 1-9.");
                Console.ForegroundColor = ConsoleColor.White;
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        if(pole1 == 0)
                        {
                            pole1 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if(pole1 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 2:
                        if (pole2 == 0)
                        {
                            pole2 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole2 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 3:
                        if (pole3 == 0)
                        {
                            pole3 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole3 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 4:
                        if (pole4 == 0)
                        {
                            pole4 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole4 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 5:
                        if (pole5 == 0)
                        {
                            pole5 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole5 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 6:
                        if (pole6 == 0)
                        {
                            pole6 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole6 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 7:
                        if (pole7 == 0)
                        {
                            pole7 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole7 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 8:
                        if (pole8 == 0)
                        {
                            pole8 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole8 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                    case 9:
                        if (pole9 == 0)
                        {
                            pole9 = 1;
                            goto podminkaNaVyhru1;
                        }
                        if (pole9 > 0)
                        {
                            goto hrac1;
                        }
                        break;
                }
            }

            //Hra
            hrac2:
                if (hrac2 == true)
                {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hráč 1 má " + bodyHrac1 + " bodů.");
                Console.WriteLine("Hráč 2 má " + bodyHrac2 + " bodů.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole1 + "|" + pole2 + "|" + pole3 + "|" + "              Příklad: | 1 | 2 | 3 |");
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole4 + "|" + pole5 + "|" + pole6 + "|" + "                       | 4 | 5 | 6 |");
                Console.WriteLine("-------" + "                       -------------");
                Console.WriteLine("|" + pole7 + "|" + pole8 + "|" + pole9 + "|" + "                       | 7 | 8 | 9 |");
                Console.WriteLine("-------" + "                       -------------");

                //Vyber Poli
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (pole1 > 0 && pole2 > 0 && pole3 > 0 && pole4 > 0 && pole5 > 0 && pole6 > 0 && pole7 > 0 && pole8 > 0 && pole9 > 0)
                {
                    Console.WriteLine("Remíza.");
                    pole1 = 0;
                    pole2 = 0;
                    pole3 = 0;
                    pole4 = 0;
                    pole5 = 0;
                    pole6 = 0;
                    pole7 = 0;
                    pole8 = 0;
                    pole9 = 0;
                    goto playAgain;
                }
                Console.WriteLine("Hráči 2, Vyber si své pole 1-9.");
                Console.ForegroundColor = ConsoleColor.White;
                switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                        if (pole1 == 0)
                        {
                            pole1 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole1 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 2:
                        if (pole2 == 0)
                        {
                            pole2 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole2 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 3:
                        if (pole3== 0)
                        {
                            pole3 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole3 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 4:
                        if (pole4 == 0)
                        {
                            pole4 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole4 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 5:
                        if (pole5 == 0)
                        {
                            pole5 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole5 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 6:
                        if (pole6 == 0)
                        {
                            pole6 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole6 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 7:
                        if (pole7 == 0)
                        {
                            pole7 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole7 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 8:
                        if (pole8 == 0)
                        {
                            pole8 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole8 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                    case 9:
                        if (pole9 == 0)
                        {
                            pole9 = 2;
                            goto podminkaNaVyhru2;
                        }
                        if (pole9 > 0)
                        {
                            goto hrac2;
                        }
                        break;
                }
            }

        podminkaNaVyhru1:
            if (pole1 == pole2 && pole2 == pole3)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole1 == pole5 && pole5 == pole9)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole1 == pole4 && pole4 == pole7)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole3 == pole5 && pole5 == pole7)
            {
                if (pole3 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole3 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole3 == pole6 && pole6 == pole9)
            {
                if (pole3 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole3 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole7 == pole8 && pole8 == pole9)
            {
                if (pole7 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole7 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole2 == pole5 && pole5 == pole8)
            {
                if (pole2 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole2 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole4 == pole5 && pole5 == pole6)
            {
                if (pole4 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole4 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            goto hrac2;

        podminkaNaVyhru2:

            if (pole1 == pole2 && pole2 == pole3)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole1 == pole5 && pole5 == pole9)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole1 == pole4 && pole4 == pole7)
            {
                if (pole1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole3 == pole5 && pole5 == pole7)
            {
                if (pole3 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole3 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole3 == pole6 && pole6 == pole9)
            {
                if (pole3 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole3 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole7 == pole8 && pole8 == pole9)
            {
                if (pole7 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole7 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole2 == pole5 && pole5 == pole8)
            {
                if (pole2 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole2 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
            if (pole4 == pole5 && pole5 == pole6)
            {
                if (pole4 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 1 vyhrál!");
                    bodyHrac1++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
                if (pole4 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hráč 2 vyhrál!");
                    bodyHrac2++;
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tabulka;
                }
            }
                goto hrac1;
        //goto k tabulce
        tabulka:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole1 + "|" + pole2 + "|" + pole3 + "|" + "              Příklad: | 1 | 2 | 3 |");
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole4 + "|" + pole5 + "|" + pole6 + "|" + "                       | 4 | 5 | 6 |");
            Console.WriteLine("-------" + "                       -------------");
            Console.WriteLine("|" + pole7 + "|" + pole8 + "|" + pole9 + "|" + "                       | 7 | 8 | 9 |");
            Console.WriteLine("-------" + "                       -------------");
            playAgain:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Zahrát Znovu? \r\n 1) Ano \r\n 2) Ne");
            int playAgain = int.Parse(Console.ReadLine());
            if(playAgain == 1)
            {
                Console.Clear();
                goto zacatek;
            }
            else
            {
                return;
            }
        }
    }
}