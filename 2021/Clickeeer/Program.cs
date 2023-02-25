using System;

namespace Clickeeer
{
    class Program
    {
        static void Main(string[] args)
        {
            int body = 0;
        loop:
            Console.WriteLine(body);
            ConsoleKeyInfo ClickerInfo;
            while ((ClickerInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            { switch (ClickerInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        body++;
                        goto loop;
                        break;
                }
            }
        }
    }
}
