using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racuni.Model;
using System.IO;

namespace Racuni.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Unos novog računa d/n?");

                if (Console.ReadLine().ToLower() != "d")
                    break;

                Racun noviRacun = UnosRacuna();
                int rbrStavke = 0;
                while (true)
                {
                    Console.WriteLine("Želite li još stavki d/n");
                    if (Console.ReadLine().ToLower() != "d")
                        break;
                    rbrStavke++;
                    Stavka novaStavka = UnosStavke(rbrStavke);
                    noviRacun.DodajStavku(novaStavka);
                }
                noviRacun.SpremiUDatoteku();
            }

            Console.ReadKey();
        }

        static Racun UnosRacuna()
        {
            Console.WriteLine("Naziv kupca:");
            string nazivKupca = Console.ReadLine();

            Console.WriteLine("Djelatnik:");
            string djelatnik = Console.ReadLine();

            //Console.WriteLine("Broj računa: ");
            //string brojRacuna = Console.ReadLine();

            //Console.WriteLine("Kupac:");

            Racun noviRacun = new Racun(DajIduciBrojRacuna().ToString())
            {
                //BrojRacuna = brojRacuna,
                Djelatnik = djelatnik,
                NazivKupca = nazivKupca,

            };
            noviRacun.StatusSpremanjaEvent += StatusSpremanjaHandler;

            return noviRacun;
        }

        static void StatusSpremanjaHandler(Exception greska)
        {
            if (greska == null)
            {
                //sve ok
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Račun je uspješno spremljen.");
            }
            else
            {
                //Greška: poruka
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Greška:{0}", greska.Message);
            }
            Console.ResetColor();
        }

        static Stavka UnosStavke(int redniBroj)
        {
            Console.WriteLine("Naziv proizvoda:");
            string nazivProizvoda = Console.ReadLine();

            Console.WriteLine("Količina: ");
            int kolicina = int.Parse(Console.ReadLine());

            Console.WriteLine("Cijena: ");
            decimal cijena = decimal.Parse(Console.ReadLine());

            Stavka novaStavka = new Stavka(redniBroj)
            {
                Cijena = cijena,
                Kolicina = kolicina,
                NazivProizvoda = nazivProizvoda
            };

            return novaStavka;
        }

        static int DajIduciBrojRacuna()
        {
            string putanja = string.Format("{0}\\{1}",
                Environment.CurrentDirectory,
                "Računi");

            if (Directory.Exists(putanja))
            {
                var najveci = (from fl in Directory.GetFiles(putanja)
                               orderby fl descending
                               select fl).First();
                string fajl = Path.GetFileNameWithoutExtension(najveci);
                //alternativa 1
                var alternativa1 = int.Parse((from fl in Directory.GetFiles(putanja)
                                              orderby fl descending
                                              select Path.GetFileNameWithoutExtension(fl)).First()) + 1;


                return int.Parse(fajl) + 1;
            }
            else
            {
                return 1;
            }
        }

    }
}
