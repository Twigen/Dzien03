using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class Samochod: Pojazd
    {
        public void Uruchom()
        {
            Console.WriteLine("Uruchom");
        }

        public void Zatankuj()
        {
            Console.WriteLine("zalej");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("silnik stop");
        }
    }
}
