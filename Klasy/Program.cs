﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Fiat",180);
            //samochod.UstawPredkosc(200);
            samochod.Predkosc = 200;
            Console.WriteLine(samochod.Predkosc);

            Console.ReadKey();
        }
    }
}
