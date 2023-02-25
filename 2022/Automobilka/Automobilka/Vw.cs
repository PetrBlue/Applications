using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Automobilka
{
    internal class Vw : Auto, IAuto
    {
        public Vw(string barva, string vyrobce, string name, int numDoor, int price) : base(barva, vyrobce, name, numDoor, price)
        {

        }
        public virtual void GetPrice(Vw vw)
        {
            Console.WriteLine($"This car costs {vw.price}");
        }
        public void Repaint(Auto auto, string paint)
        {
            auto.barva = paint;
        }
    }
}
