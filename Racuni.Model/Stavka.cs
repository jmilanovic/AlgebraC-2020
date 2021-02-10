using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racuni.Model
{
    public class Stavka
    {
        public int RedniBroj { get; private set; }
        public string NazivProizvoda { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public Stavka(int redniBroj)
        {
            this.RedniBroj = redniBroj;
        }

        public decimal UkupnaCijena()
        {
            return this.Kolicina * this.Cijena;
        }
    }
}
