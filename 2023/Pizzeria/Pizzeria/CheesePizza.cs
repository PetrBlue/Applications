using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(string name) : base(name)
        {
            alergeny = new List<Alergeny>
            {
                Alergeny.Eidam,
                Alergeny.Tomatoes
            };
        }
    }
}
