using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobil: Vozilo
    {
        private decimal _ccm;
        public decimal Ccm
        {
            get
            {
                return _ccm;
            }

            set
            {
                _ccm = value;
            }
        }

        public Automobil(int ks)
            :base(ks)//pozivamo konstruktor bazne klase
        {

        }

        public override string ToString()
        {
            return string.Format("Naziv:{0}, KS:{1}", base.Naziv, base.Ks);
        }


    }
}
