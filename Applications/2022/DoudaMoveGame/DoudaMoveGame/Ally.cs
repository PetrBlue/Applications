using DoudaMoveGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudaMoveGame
{
    internal class Ally : Cube
    {
        public Ally(Form1 form) : base(form)
        {
            p.BackColor = Color.Green;
        }
    }
}
