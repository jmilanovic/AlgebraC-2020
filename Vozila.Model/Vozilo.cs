using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozilo
    {
        private string _naziv;
        private string _boja;
        private int _ks;

        public string Naziv
        {
            get
            {
                return _naziv;
            }

            set
            {
                _naziv = value;
            }
        }

        public string Boja
        {
            get
            {
                return _boja;
            }

            set
            {
                _boja = value;
            }
        }

        public int Ks
        {
            get
            {
                return _ks;
            }

            set
            {
                _ks = value;
            }
        }

        public Vozilo(int ks)
        {
            _ks = ks;
        }

        public decimal KSToKW()
        {
            return Ks * (decimal)0.736;
        }
    }
}
