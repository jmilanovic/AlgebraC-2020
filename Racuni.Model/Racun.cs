using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racuni.Model
{
    public class Racun
    {
        #region Properties

        public delegate void StatusSpremanja(Exception greska);
        public event StatusSpremanja StatusSpremanjaEvent;

        public string NazivKupca { get; set; }
        public string Djelatnik { get; set; }
        public DateTime Datum { get; private set; }
        public string BrojRacuna { get; private set; }
        public List<Stavka> Stavke { get; private set; }
        #endregion

        public Racun(string brojRacuna)
        {
            this.BrojRacuna = brojRacuna;
            this.Datum = DateTime.Now;
            this.Stavke = new List<Stavka>();
        }

        #region Public Methods
        public decimal UkupanIznos()
        {
            decimal ukupno = 0;
            foreach (var st in this.Stavke)
            {
                ukupno += st.UkupnaCijena();
            }
            return ukupno;
        }

        public void SpremiUDatoteku()
        {
            string putanja = string.Format("{0}\\{1}\\{2}.txt",
                Environment.CurrentDirectory,
                "Računi",
                this.BrojRacuna);

            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(putanja)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(putanja));
                }

                using (FileStream fs = new FileStream(putanja, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Naziv kupca: " + this.NazivKupca);
                        sw.WriteLine("Djelatnik: " + this.Djelatnik);
                        sw.WriteLine("Datum: " + this.Datum);
                        sw.WriteLine("Broj računa: " + this.BrojRacuna);
                        SpremiStavkeUDatoteku(sw);
                        sw.WriteLine("Ukupan iznos: " + this.UkupanIznos());
                    }

                }

                //Uspješno smo spremili datoteku.
                if (StatusSpremanjaEvent != null)
                    StatusSpremanjaEvent(null);
            }
            catch (Exception ex)
            {
                if (StatusSpremanjaEvent != null)
                {
                    if (ex.Message.Contains("already exists"))
                    {
                        StatusSpremanjaEvent(new Exception("Račun sa istim brojem već postoji."));
                    }
                    else
                    {
                        //Spremanje nije uspjelo. Prikaži grešku.
                        StatusSpremanjaEvent(ex);
                    }
                }
            }

        }

        public void DodajStavku(Stavka novaStavka)
        {
            this.Stavke.Add(novaStavka);
        }

        #endregion

        #region Private Methods
        private void SpremiStavkeUDatoteku(StreamWriter sw)
        {

            foreach (Stavka st in this.Stavke)
            {
                sw.WriteLine();
                sw.WriteLine("-----------" + st.RedniBroj + ". stavka-----------");
                sw.WriteLine("Naziv proizvoda: " + st.NazivProizvoda);
                sw.WriteLine("Količina: " + st.Kolicina);
                sw.WriteLine("Cijena: " + st.Cijena);
                sw.WriteLine("Ukupna cijena: " + st.UkupnaCijena());
            }
        }

        #endregion
    }
}
