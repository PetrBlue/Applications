using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace PingPong
{
    internal class Player
    {
        public Point location;
        public Direction direction;
        public int speed = 10;
        public Color color;
        public int height, width;
        public Panel p { get; private set; } = new Panel();

        public Player(Point location, Color color, int width, Form1 form)
        {
            this.location = location;
            this.color = color;
            this.height = form.Height / 5;
            this.width = width;
            CreatePlayer(form);
        }
        void CreatePlayer(Form1 form) {
            p.Location = location;
            p.BackColor = color;
            p.Width = width;
            p.Height = height;
            form.Controls.Add(p);
        }
        public void MovePlayer(Form1 form) {
           
            location = PlayerChangeLocation();

            form.Refresh();
        }

        private Point PlayerChangeLocation() {
            if (direction == Direction.UP)
            {
                return new Point(location.X, location.Y - speed);
            }
            else if (direction == Direction.DOWN)
            {
                return new Point(location.X, location.Y + speed);
            }
                return new Point(0, 0);
            }
        public void UpdateControls() { }
    }
}
