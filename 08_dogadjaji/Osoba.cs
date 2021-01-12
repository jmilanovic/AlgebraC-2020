namespace _08_dogadjaji
{
    internal class Osoba
    {
        private string ime;

        public string Ime {
            get => ime;
            set { 
                ime = value;
                if (NaPromjenuImena != null) {
                    NaPromjenuImena(this, new System.EventArgs());
                }
                
            } 
        }
        public delegate void NaPromjenuImenaDelegat(object sender, System.EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;
    }
}