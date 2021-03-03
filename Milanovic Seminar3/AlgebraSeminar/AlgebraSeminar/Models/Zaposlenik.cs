using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AlgebraSeminar.Models
{
    public partial class Zaposlenik
    {
        public int IdZaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
    }
}
