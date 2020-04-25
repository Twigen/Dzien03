using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Prostokat:Figura, IFigura, IFiguraStat
    {
        private int bokA;
        private int bokB;
        public Prostokat(int bokA,int bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            liczbaBokow = 2;
        }
        //public int ObliczPole()
        //{
        //    return bokA * bokB;
        //}
        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }

        public double ObliczObw()
        {
            return 2 * bokA + 2 * bokB;
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public int PodajLiczbeBokow()
        {
            return liczbaBokow;
        }
    }
}
