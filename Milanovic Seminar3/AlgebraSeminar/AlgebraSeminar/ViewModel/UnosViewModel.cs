using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlgebraSeminar.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AlgebraSeminar.ViewModel
{
    public class UnosViewModel
    {

        [DataType(DataType.Date)]
        public Seminar seminarVm { get; set; }
        public Predbiljezba predbiljezbaVm { get; set; }

        [DataType(DataType.Date)]

        public int IdPredbiljezba { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int IdSeminar { get; set; }
        public bool Status { get; set; }

        public int Brojpolaznika { get; set; }
        public virtual Seminar IdSeminarNavigation { get; set; }


        public string Naziv { get; set; }
        public string Opis { get; set; }


        public bool Popunjen { get; set; }
        public string Predavac { get; set; }

    }
}
