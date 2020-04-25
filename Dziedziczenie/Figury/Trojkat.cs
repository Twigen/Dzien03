using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Trojkat: Figura
    {
        private double? bokA = null;
        private double? bokB = null;
        private double? bokC = null;
        private double? wysokosc = null;

        public Trojkat(int a, int b, int c)
        {
            bokA = a;
            bokB = b;
            bokC = c;
            liczbaBokow = 3;
        }
        public Trojkat(int podstawa, int wysokosc)
        {
            bokA = podstawa;
            this.wysokosc = wysokosc;
        }
        public double ObliczPole( )
        {
            if (bokA != null && wysokosc != null)
                return 0.5 * (double)bokA * (double)wysokosc;
            else 
            {
                double p = ((double)bokA * (double)bokB * (double)bokC) * 0.5;
                return Math.Sqrt(p * (p - (double)bokA) * (p - (double)bokC) * (p - (double)bokB));
            } 
        }
        public double ObliczObw()
        {
            if (wysokosc == null)
                return 0;
            else
            {
               return (double)bokA + (double)bokB + (double)bokC;
            }
        }
    }
}
