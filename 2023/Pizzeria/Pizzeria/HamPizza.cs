using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class HamPizza : Pizza
    {
        public HamPizza(string name) : base(name)
        {
            alergeny = new List<Alergeny>
            {
                Alergeny.Ham,
                Alergeny.Eidam,
                Alergeny.Tomatoes
            };
        }
    }
}
