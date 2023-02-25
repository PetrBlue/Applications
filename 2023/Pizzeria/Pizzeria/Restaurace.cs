using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Restaurace
    {
        Random rnd = new Random();
        List<Lidi> lidiVrestauraci = new List<Lidi>();
        internal static List<Stul> seznamStolu = new List<Stul>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        void PrichodOdchodLidi(Form1 form)
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Enabled = true;
        }
        private void timer_Tick(object? sender, EventArgs e)
        {
            timer.Interval = rnd.Next(1000, 5000);
            lidiVrestauraci.Add(new Lidi(Lidi.jmena[rnd.Next(0, Lidi.jmena.Length)], rnd.Next(500, 1000)));
            ZkontrolujMistoUstolu();
        }
        void VytvorStoly(int pocet)
        {
            for(int i = 0; i < pocet; i++)
            {
                seznamStolu.Add(new Stul(rnd.Next(2, 5)));
            }
        }
        void ZkontrolujMistoUstolu()
        {
            //foreach()
        }
    }
}
