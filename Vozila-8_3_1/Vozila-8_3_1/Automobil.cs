using System;
using System.Collections.Generic;
using System.Text;

namespace Vozila_8_3_1
{
    class Automobil:Vozilo
    {

        double ccm;

        public double Ccm { get => ccm; set => ccm = value; }

        public override string ToString()
        {
            return "Naziv vozila je: "+Naziv+" KS su: "+Ks;
        }
    
    }
}
