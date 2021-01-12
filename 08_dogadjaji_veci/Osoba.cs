using System;

// PUBLISHER

namespace _08_dogadjaji_veci
{
    internal class Osoba
    {
        private string ime;
        private string prezime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime;

            set {
                // prezime nije Null i nije razmak te je novo razlicito od starog prezimena 
                if (!string.IsNullOrWhiteSpace(prezime) && value != prezime)
                {
                    // ukoliko posti event pozovi ga
                    if (PromijenjenoPrezime != null)
                    {
                        PromijenjenoPrezime(prezime, value);
                    }
                }
                prezime = value;
            } 
        
        }

        public delegate void NaPromjenuPrezimenaDelegat(string staroPrezime, string novoPrezime);
        public event NaPromjenuPrezimenaDelegat PromijenjenoPrezime;

        public delegate void PozivPunogImenaDelegat();
        public event PozivPunogImenaDelegat PozvanaMetodaPunoIme;


        internal string PunoIme()
        {
            if (PozvanaMetodaPunoIme != null)
            {
                PozvanaMetodaPunoIme();
            }
            return "Moje ime je "+this.Ime + " " + this.Prezime;
        }

        
    }
}