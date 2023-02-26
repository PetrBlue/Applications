using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixerProjekt
{
    internal class Mixer
    {
        //float otacky; - pomoci metod
        //public float otacky; - vsude
        //private float otacky; - read only
        float otacky;
        private float Otacky { get; set; }
        private float pitch { 
            get { return otacky; }
            set { Console.WriteLine("Změnil jsem otáčky"); 
                otacky = value; }
        }
        public float vykon;
        public float objem;
        public int zarucniDoba;
        public int cena;
        public bool isOn;
        List<string> mixerList = new List<string>();

        //getter and setter
        public float getOtacky()
        {
            return otacky;
        }
        public void setOtacky(float x)
        {
            otacky = x;
        }
        public Mixer(float otacky, float vykon, float objem, int zarucniDoba, int cena)
        {
            this.cena = cena;
            this.otacky = otacky;
            this.vykon = vykon;
            this.objem = objem;
            zarucniDoba = 24;
            isOn = false;
        }
        public void NaplnMixer(string item)
        {
            mixerList.Add(item);
        }
        public bool ZapniMixer()
        {
            return this.isOn = true;
        }
    }
}
