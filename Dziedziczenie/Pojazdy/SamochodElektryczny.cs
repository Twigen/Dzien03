﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class SamochodElektryczny:Samochod
    {
        private double pojemnoscBaterii;
        void Zatankuj()
        {
            Console.WriteLine("podlacz do pradu");
        }

    }
}
