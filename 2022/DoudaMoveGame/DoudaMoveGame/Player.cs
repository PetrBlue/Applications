using DoudaMoveGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudaMoveGame
{
    internal class Player : Cube
    {
        public Player(Form1 form) : base(form)
        {
            p.BackColor = Color.Black;
            p.Location = new Point((form.Width / 2) - form.Width, form.Height / 2);
        }
    }
}
    