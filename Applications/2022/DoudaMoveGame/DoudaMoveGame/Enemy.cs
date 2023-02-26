using DoudaMoveGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudaMoveGame
{
    internal class Enemy : Cube
    {
        public Enemy(Form1 form) : base(form)
        {
            p.BackColor = Color.Red;
        }

        public void GenerateEnemy(Form1 form, int num)
        {
            for (int i = 0; i < num; i++)
            {
                new Enemy(form);
            }
        }
    }
}
