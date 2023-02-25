using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pexeso
{
    internal class Puzzlik : GameControl
    {
        //string[] txt = { "Auto", "Krabice", "Pocitac", "Smth", "Monster", "UrMom", "69" };
        //object<object> temp = [{
            
        //    }];
        //Tuple<>
        IDictionary<Puzzlik, Color> seznam = new Dictionary<Puzzlik, Color>();
        public Puzzlik(Form1 form)
        {
            Button tmp = new Button();
            tmp.Height = (int)(form.Height / Math.Sqrt(layout.Controls.Count));
            tmp.Width = (int)(form.Width / Math.Sqrt(layout.Controls.Count));
            tmp.BackColor = Color.Red;
            tmp.ForeColor = Color.Magenta;
        }
    }
}
