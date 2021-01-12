using System;
using System.Collections.Generic;
using System.Text;

namespace alg_structures
{
    // Struktura je vrijednosnog tipa pa svi elementi MORAJU biti vrijednosni
    struct Predmet   // NE MOGU SE NASLJEDJIVATI
    {
        private string v1;
        private int v2;

        public Predmet(string v1, int v2) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Naziv { get; internal set; }  //Moze, vrijednosni
        public int ECTS { get; internal set; }  //Moze, vrijednosni

        public Profesor prof { get; set; }  // Ovo ne moze zato jer je objekt REFERENTNI TIP

        public override string ToString()
        {
            return this.Naziv + " " + this.ECTS + " " + prof.Prezime1;
        }

    }
}
