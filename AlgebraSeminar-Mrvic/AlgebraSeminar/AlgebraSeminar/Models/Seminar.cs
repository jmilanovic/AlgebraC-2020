using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AlgebraSeminar.Models
{
    public partial class Seminar
    {
        public Seminar()
        {
            Predbiljezbas = new HashSet<Predbiljezba>();
        }

        public int IdSeminar { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public bool Popunjen { get; set; }
        public string Predavac { get; set; }

        public virtual ICollection<Predbiljezba> Predbiljezbas { get; set; }
    }
}
