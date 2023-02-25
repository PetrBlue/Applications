using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilka
{
    internal class Skoda : Auto, IAuto
    {
        public Skoda(string barva, string vyrobce, string name, int numDoor, int price) : base(barva, vyrobce, name, numDoor, price)
        {

        }
        public virtual void GetPrice(Skoda skoda)
        {
            Console.WriteLine($"This car costs {skoda.price}");
        }
        public void Repaint(Auto auto, string paint)
        {
            auto.barva = paint;
        }

    }
}
