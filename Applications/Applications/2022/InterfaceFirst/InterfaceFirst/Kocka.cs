using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFirst
{
    internal class Kocka : Zvire, IZvire
    {
        public string name => throw new NotImplementedException();
        public Kocka(string sound) : base(sound)
        {
            this.sound = sound;
        }
        public void VydejZvuk()
        {
            Console.WriteLine("Manu");
        }
    }
}
