using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilka
{
    internal class Auto 
    {
        public string barva { get; set; }
        protected string vyrobce;
        protected string name;
        protected int numDoor;
        public int price { get; protected set; }
        public Auto(string barva, string vyrobce, string name, int numDoor, int price)
        {
            this.barva = barva;
            this.vyrobce = vyrobce;
            this.name = name;
            this.numDoor = numDoor;
            this.price = price;
        }
    }
}
