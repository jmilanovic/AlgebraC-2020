using System;

namespace _14_Osoba_Zivotinja
{
    //internal class Osoba : IMojInterface, ICloneable, IDisposable, IComparable<Osoba> //moze i ovako
    internal class Osoba : IMojInterface, ICloneable, IDisposable, IComparable

    {
        public string Ime { get; internal set; }
        public string Prezime { get; internal set; }
        public int placa { get; internal set; }
        public Osoba Partner { get; internal set; }

        ~Osoba()
        {
            Dispose(false);
            Console.WriteLine("Objekt unisten");
        }

        public Osoba()
        {
            this.placa = 6500;
        }
        public Osoba(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.placa = 7500;
        }

        public object Clone()
        {

            return new Osoba(this.Ime, this.Prezime);
        }

        public string PunoIme()
        {
            if (this.Partner == null)
            {
                this.Partner = new Osoba() { Ime = "Jane", Prezime = "DOe" };
            }
            return string.Format("Ja se zovem {0} {1}, i moj partner je {2} {3}, moja placa je: {4}"
                , this.Ime
                , this.Prezime
                , this.Partner.Ime
                , this.Partner.Prezime
                ,this.placa);
        }

        private bool isDisposed = false;

        public void Dispose(bool disposing)

        {

            if (disposing)

            {

                // Code to dispose the managed resources of the class

            }

            // Code to dispose the un-managed resources of the class

            isDisposed = true;

        }

        public void Dispose()

        {

            Dispose(true);

            GC.SuppressFinalize(this);

        }

        public int CompareTo(Osoba os)
        {
            if (this.placa < os.placa)
            {
                return 1;
            }
            else if (this.placa > os.placa)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            //Koristimo ga za usporedbu 2 objekta.
            //Provjeravamo jesu li isti.
           // return 0;  // 1 ako je veci, -1 ako je manji ili 0 ako su isti
        }

        public int CompareTo(object obj)
        {
            return CompareTo((Osoba)obj);
        }
    }
}