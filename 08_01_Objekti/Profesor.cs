using System;
using System.Collections.Generic;
using System.Text;

namespace _08_01_Objekti
{
    class Profesor
    {
        private string prezime;

        public Profesor(string Ime, int Placa, string Predmet)
        {
            this.Ime = Ime;
            this.Placa = Placa;
            this.Predmet = Predmet;
        }

        public string Ime { get; }
        public int Placa { get; }
        public string Predmet { get; }
        //public string Prezime { get => prezime; set => prezime = value; }
        // primjer MUTATOR
        public string Prezime {set => prezime = StringExtensions.FirstCharToUpper(value); } // Ne dozvoljava dohvacanje prezimena, samo postavljanje
        public string Prezime1
        {
            get
            {
                return this.prezime;
            }
            set
            {
                prezime = value;
            }
        }
    }
}
