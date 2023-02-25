using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    internal class Ball
    {
        public float speed;
        public float direction;
        public Color color;

        public Ball(Color color, Form1 form) {
            this.color = color;
            speed = 10;
        }
        public void CreateBall(Form1 form) { 
            Graphics g = form.CreateGraphics();
            SolidBrush blackBrush = new SolidBrush(color);
            Size size = new Size(15, 15);
            Point tmpP = new Point(form.Width / 2 - size.Width / 2,
                form.Height / 2 - size.Height / 2);
            g.FillEllipse(blackBrush, new Rectangle(tmpP, size));
        }
    }
}
