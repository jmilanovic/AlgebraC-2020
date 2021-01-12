using System;
using System.Collections.Generic;
using System.Text;

namespace Vozila_8_3_1
{
    class Vozilo
    {
        string naziv;
        string boja;
        int ks;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Boja { get => boja; set => boja = value; }
        public int Ks { get => ks; set => ks = value; }

        public double KStoKW(int ks)
        { 
        return Ks*0.736;
        }
    }
}
