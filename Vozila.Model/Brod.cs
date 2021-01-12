using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Brod: Vozilo
    {
        public delegate void PromjenaIstisnineDel(decimal novaIstisnina);
        public event PromjenaIstisnineDel IstisninaPromijenjena;

        private decimal _istisnina;
        public decimal Istisnina
        {
            get { return _istisnina; }
            set
            {
                _istisnina = value;

                if (IstisninaPromijenjena != null)
                    IstisninaPromijenjena(value);
            }
        }

        public Brod(int ks)
            :base(ks)
        {

        }
        public override string ToString()
        {
            return "Ovo je brod:"+this.Naziv + this.Istisnina + this.Boja;
        }
    }
}
