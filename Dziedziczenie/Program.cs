using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dziedziczenie.Figury;
using Dziedziczenie.KlasaAbstrakcyjna;
using Dziedziczenie.KlasaStatyczna;
using Dziedziczenie.MetodyWirtualne;
using Dziedziczenie.Pojazdy;
using Dziedziczenie.Przeciazanie;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prostokat prostokat = new Prostokat(2, 4);
            //double pole = prostokat.ObliczPole();
            //Console.WriteLine("pole prostokata to {0}",pole);
            //Kwadrat kwadrat = new Kwadrat(2);
            //pole = kwadrat.ObliczPole();
            //Console.WriteLine("pole kwadratu to {0}",pole);
            //Console.WriteLine("czy kwadrat {0}", kwadrat.CzyKwadrat());
            //Samochod samochod = new Samochod();
            //samochod.Uruchom();
            //samochod.Zatankuj();
            //samochod.Zatrzymaj();
            //Console.WriteLine("hostname: {0}", Utils.hostName);
            //Console.WriteLine("wartosc max: {0}",Utils.GetMaxValue(3,0,5,30));
            //Product product = new Product("nazwa", 555);
            //product.ShowPrice();
            //Wektor w1 = new Wektor(2, 5);
            //Wektor w2 = new Wektor(1, 6);
            ////Wektor w = w1.Add(w2);
            //Wektor w = w1 + w2;
            //w = w1 + 2;
            //w.Print();
            Kot kot = new Kot();
            Console.WriteLine(kot);
            Console.ReadKey();
            
        }
    }
}
