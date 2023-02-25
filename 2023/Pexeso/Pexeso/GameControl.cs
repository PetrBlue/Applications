using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pexeso
{
    internal class GameControl
    {
        protected FlowLayoutPanel layout = new FlowLayoutPanel();
        void Init(Form1 form)
        {
            AddLayout(form);
        }
        void AddLayout(Form1 form)
        {
            layout.Height = form.Height;
            layout.Width = form.Width;
            form.Controls.Add(layout);
        }
        void AddButton(Form1 form, int pocet)
        {
            for(int i = 0; i < pocet; i++)
            {
                layout.Controls.Add(new Button());
            }
        }
    }
}
