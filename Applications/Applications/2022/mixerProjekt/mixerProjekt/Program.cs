using System;

namespace mixerProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Mixer tesla3000 = new Mixer(20f, 240f, 1500f, 2400, 1000);
            Mixer ingrid = new Mixer(20f, 240f, 1500f, 2400, 1000);
            tesla3000.cena = 2000;
            tesla3000.ZapniMixer();
            Console.WriteLine("Zapl se mixer? " + tesla3000.ZapniMixer());
            Console.WriteLine("Zapl se mixer? " + ingrid.ZapniMixer());
            Console.WriteLine("Nový mixér tesla3000 je právě za cenu {0}",(tesla3000.cena));
        }
    }
}