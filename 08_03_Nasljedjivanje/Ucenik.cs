namespace _08_03_Nasljedjivanje
{
    internal class Ucenik : Osoba
    {
        //private string Ime;
        //private string Prezime;

        //public Ucenik(string Ime, string Prezime)
        //{
        //    this.Ime = Ime;
        //    this.Prezime = Prezime;
        //}
        private int matematika;
      
        public Ucenik():base("","")
        {
        }
        
        public Ucenik(string ime, string prezime) : base(ime, prezime)
        {
        }

        public Ucenik(string ime, string prezime, int Matematika) : this(ime, prezime)
        {
            this.Matematika = Matematika;

        }
        public override string ToString() //Premoscivanje
        {
            return PunoIme();
        }
        public new string PunoIme()  // HIDING iliti sjencenje....
        {
            return Prezime + ", " + Ime;
        }

        public int Matematika { get => matematika; set => matematika = value; }
    }
}