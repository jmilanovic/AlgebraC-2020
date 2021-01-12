namespace _09_osoba
{
    internal class Osoba
    {
        string inicijali = "";
        private string ime;
        private string prezime;

        public Osoba(string Ime, string Prezime)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
        }
        public override string ToString()
        {
            return string.Format($"Moje ime je {Ime}, prezime je {Prezime}, Moji inicijali su: {Inicijali}");
        }

        public string Ime { 
            get { return ime; } 
            set {
                ime = value.Substring(0, 1).ToUpper()+ value.Substring(1).ToLower();
            } 
        }
        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }


        public string Inicijali { 
            get {
                inicijali = (this.Ime.Substring(0, 1)+this.Prezime.Substring(0, 1)).ToUpper();

                return inicijali; 
            }
            
            }
    }
}