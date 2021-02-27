using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AlgebraSeminar.Models
{
    public partial class Predbiljezba
    {
        public int IdPredbiljezba { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public int IdSeminar { get; set; }
        public bool Status { get; set; }

        public virtual Seminar IdSeminarNavigation { get; set; }
    }
}
