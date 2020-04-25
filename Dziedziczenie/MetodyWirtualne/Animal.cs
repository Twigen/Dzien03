using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.MetodyWirtualne
{
    class Ssak
    {
        public void Karmienie()
        {
            Console.WriteLine("operacja karmienia");
        }
    }
    class Kot: Ssak
    {
        public void Karmienie()
        {
            Console.WriteLine("Kot - karmienie");
        }
        public override string ToString()
        {
            return "obiekt klasy kot";
        }
    }
}
