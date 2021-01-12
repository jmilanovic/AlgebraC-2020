namespace alg_13_Enums
{
    //public enum Spol { 
    //Muski,
    //Zenski
    //}
    internal class Osoba
    {
        private string ime;

        private Spol spol;

        public Osoba(string ime)
        {
            this.ime = ime;
            this.spol = Spol.Zenski;
        }

        public Osoba(string ime, Spol s)
        {
            this.ime = ime;
            this.spol = s;
        }

        public override string ToString()
        {
            return "Ime: " + this.ime + " A spol je:" + this.spol;
        }

    }
}