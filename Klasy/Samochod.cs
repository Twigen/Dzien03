using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Samochod
    {
        private string marka;
        private int predkoscMax;
        private int liczbaDrzwi;

        public int LiczbaDrzwi { get; set; }

        //deklaracja wlasciwosci klasy(property)

        public int Predkosc { 
            get { return predkoscMax; } 
            set { 
                if(value <= 0)
                {
                    Console.WriteLine("predkosc <=0 ");
                }
                else
                {
                    predkoscMax = value;
                }    
                 }
        }

        public Samochod (string marka, int predkosc)
        {
            this.marka = marka;
            predkoscMax = predkosc;
        }

        /// <summary>
        /// Metoda zmienia predkość maksymalną
        /// </summary>
        /// <param name="predkosc">nowa prędkość maksymalna</param>
        public void UstawPredkosc(int predkosc)
        {
            predkoscMax = predkosc;
        }
        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }
    }
}
