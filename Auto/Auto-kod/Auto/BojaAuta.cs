using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
{
    class BojaAuta
    {
        public string boja="plava";
        public int KS=45;

        public override string ToString()
        {
            // return base.ToString();
            return "Ja sam Automobil Audi A1, moja boja je: " + 
                this.boja+" Konjska snaga je:"+this.KS;
         }

        internal void DodajSnagu(int v)
        {
            this.KS = 150;
        }
    }
}
