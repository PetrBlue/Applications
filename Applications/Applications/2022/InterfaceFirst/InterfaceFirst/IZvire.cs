using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFirst
{
    internal interface IZvire
    {
        public string name { get; }
        public abstract void VydejZvuk();
    }
}
