using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_4_1_5_1_Uvod_Varijable
{
    class Vreliste
    {
        public int vreliste;
        public int lediste;
        int test;
        public override string ToString()
        {
            return "Lediste vode je: " +this.lediste+ "C\n"+"Vreliste vode je: "+this.vreliste+"C";
            
        }

        internal void UnesiVreliste(int vreliste)
        {
            this.vreliste = vreliste;
            
        }
    }
}

