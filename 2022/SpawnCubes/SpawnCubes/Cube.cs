using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnCubes
{
    internal class Cube
    {
        List<Cube> cubeList = new List<Cube>();
        int sirka, vyska, poziceX, poziceY;
        public Cube(int sirka, int vyska, int poziceX, int poziceY)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.poziceX = poziceX;
            this.poziceY = poziceY;
            cubeList.Add(this);
        }
    }
}
