using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilka
{
    internal interface IAuto
    {
        public virtual void GetPrice(Auto auto)
        {
            Console.WriteLine($"This car costs {auto.price}");
        }
        public abstract void Repaint(Auto auto, string paint); 
    }
}
