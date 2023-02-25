using System;

namespace MaffeluDemo
{
    class Program
    {
        const ConsoleColor barvaCtverce = ConsoleColor.DarkBlue;
        const ConsoleColor barvaPozadi = ConsoleColor.Green;
        const ConsoleColor barvaCoiny = ConsoleColor.Yellow;

        public static Coordinate Hero { get; set; } //Will represent our here that's moving around :P/>
        public static Coordinate Coin { get; private set; }

        static void Main(string[] args)
        {
            InitGame();

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        MoveHero(0, -1);
                        break;

                    case ConsoleKey.D:
                        MoveHero(1, 0);
                        break;

                    case ConsoleKey.S:
                        MoveHero(0, 1);
                        break;

                    case ConsoleKey.A:
                        MoveHero(-1, 0);
                        break;
                }
            }
        }

        /// <summary>
        /// Paint the new hero
        /// </summary>
        static void MoveHero(int x, int y)
        {
            Coordinate newHero = new Coordinate()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero();

                Console.BackgroundColor = barvaCtverce;
                Console.SetCursorPosition(newHero.X, newHero.Y);
                Console.Write(" ");

                Hero = newHero;
            }
        }

        /// <summary>
        /// Overpaint the old hero
        /// </summary>
        static void RemoveHero()
        {
            Console.BackgroundColor = barvaPozadi;
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(" ");
        }

        /// <summary>
        /// Make sure that the new coordinate is not placed outside the
        /// console window (since that will cause a runtime crash
        /// </summary>
        static bool CanMove(Coordinate c)
        {
            if (c.X < 0 || c.X >= Console.WindowWidth)
                return false;

            if (c.Y < 0 || c.Y >= Console.WindowHeight)
                return false;

            return true;
        }

        /// <summary>
        /// Paint a background color
        /// </summary>
        /// <remarks>
        /// It is very important that you run the Clear() method after
        /// changing the background color since this causes a repaint of the background
        /// </remarks>
        static void SetBackgroundColor()
        {
            Console.BackgroundColor = barvaPozadi;
            Console.Clear(); //Important!
        }

        /// <summary>
        /// Initiates the game by painting the background
        /// and initiating the hero
        /// </summary>
        static void InitGame()
        {
            SetBackgroundColor();

            Hero = new Coordinate()
            {
                X = 0,
                Y = 0
            };

            MoveHero(0, 0);

        }
        static void Coins()
        {
            bool hahaa = true;
            int a = 50;
            int b = 100;
            if (hahaa == true)
            {

                Random rnd = new();
                int xx = rnd.Next(a, b);
                int yy = rnd.Next(a, b);

                Coin = new Coordinate()
                {
                    X = xx,
                    Y = yy

                };
                {
                    
                }
            }
            if(Hero == Coin)
            {
                int body = 0;
                body++;
                Console.WriteLine("+1 bod \r\n Tvoje body: " + body);
            }
        }
    }

    /// <summary>
    /// Represents a map coordinate
    /// </summary>
    class Coordinate
    {
        public int X { get; set; } //Left
        public int Y { get; set; } //Top
    }
}