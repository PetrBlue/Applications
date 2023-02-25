using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Pizza
    {
        public List<Alergeny> alergeny;
        public string name { get; private set; }

        public Pizza(string name)
        {
            this.name = name;
        }
    }
}
