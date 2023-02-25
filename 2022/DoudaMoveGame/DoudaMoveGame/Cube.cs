using DoudaMoveGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudaMoveGame
{
    internal class Cube
    {
        Random rnd = new Random();
        protected Panel p;
        public Cube(Form1 form)
        {
            p = new Panel();
            p.Width = 50;
            p.Height = 50;
            p.BackColor = Color.Black;
            int x = rnd.Next(0, form.Width - 50);
            x -= x % 50;
            int y = rnd.Next(0, form.Height - 50);
            y -= y % 50;
            p.Location = new Point(x, y);
            form.Controls.Add(p);
        }
    }
}