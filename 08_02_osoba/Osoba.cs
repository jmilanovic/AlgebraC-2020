using System;

namespace _08_02_osoba
{
    internal class Osoba
    {
        private int starost=5;
        private string prezime;

        public string Ime { get; internal set; }
        internal string Prezime { get => prezime; set => prezime = value; }
        internal int Starost { get { return starost; }

            set {
                if (value < 0)
                {
                    Exception ex = new Exception("Ne moze starost biti manja od nule");
                }
                else if (value > 120) {
                    Exception ex = new Exception("Broj jedan jesi li to ti?");
                }
                else
                {
                    starost = value;
                }
                
            }
        }
        internal string StarostPozdrav
        {
            get {
                if (starost < 18)
                {
                    return "mladicu";
                }
                if (starost >= 18 && starost <= 60)
                {
                    return "gospodine";
                }
                else {
                    return "postovani gospodine";
                }
            }
        }

    }
}