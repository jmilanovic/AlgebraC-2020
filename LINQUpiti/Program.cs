using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUpiti
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();

            List<Seminar> sviSeminari = repo.SviSeminari();
            List<Polaznik> sviPolaznici = repo.SviPolaznici();

            DohvatiJedanPoIdu(sviPolaznici);
            DohvatIntervala(sviPolaznici);

            Console.ReadKey();
        }

        static void DohvatiJedanPoIdu(List<Polaznik> sviPolaznici)
        {
            List<Polaznik> polaznici = (from polo in sviPolaznici
                                        where polo.Ime.Contains("22") //== "Ime_1"
                                        select polo).ToList();
            //First() vraća prvi zapis u kolekciji
            //Ako ne nađe ništa desiti će se greška
            Polaznik prviPolaznik = polaznici.First();
            //FirstOrDefault vraća podatak ako je pronađen.
            //Ako nije, vratit će null, ali neće se desiti greška
            Polaznik prviIliDefaultPolaznik = polaznici.FirstOrDefault();

            Polaznik siguranSamDajeSamoJedan = (from p in sviPolaznici
                                                where p.Ime == "Ime"
                                                select p).SingleOrDefault();

            //var-s
            int broj = 2;
            var broj2 = 3;
            //broj2 = "pero";

            var rezultat = (from pl in sviPolaznici
                            where pl.Prezime.Contains("22")
                            select pl.DatumRodenja);

            foreach (var item in rezultat)
            {
                Console.WriteLine("Datum rodjenja polaznika s prezimenom 22:"+item.ToString());
            }

            foreach (Polaznik p in polaznici)
            {
                Console.WriteLine("Polaznik >>" + p.Ime+" "+p.Prezime+" "+p.UpisaniSeminar.Naziv+" "+p.UpisaniSeminar.Cijena);
            }

        }

        static void DohvatIntervala(IList<Polaznik> sviPolaznici)
        {
            //stariji od 35 godina,a mlađi od 120
            var interval = from pl in sviPolaznici
                           orderby pl.Prezime descending
                           where pl.DatumRodenja < DateTime.Now.AddYears(-35)
                           && pl.DatumRodenja > DateTime.Now.AddYears(-120)
                           || pl.UpisaniSeminar.Id == 2
                           select pl.UpisaniSeminar;



        }
    }
}
