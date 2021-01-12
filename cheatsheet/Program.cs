using System;
using System.Collections.Generic;
using System.Linq;

namespace cheatsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba { Ime = "Marko", Prezime = "Cvek" });
            osobe.Add(new Osoba { Ime = "Jana", Prezime = "Avena" });
            osobe.Add(new Osoba { Ime = "Nana", Prezime = "Dobra" });


            Osoba trazena_osoba = new Osoba();
            foreach (var item in osobe)
            {
                if (item.Prezime == "Cvek")
                {
                    trazena_osoba = item;
                }
                else
                {

                }
            }

            Osoba trazena_osoba_linq = (
                from tr_os      // postavimo ime varijable za svaki element kolekcije
                in osobe        // kolekcija iz koje radimo pretragu
                where tr_os.Prezime.Contains("ve")  // filter
                select tr_os    // selektiramo kompletan element
                ).LastOrDefault();


            Console.WriteLine(trazena_osoba.Prezime + " " + trazena_osoba.Ime);
            Console.WriteLine(trazena_osoba_linq.Prezime + " " + trazena_osoba_linq.Ime);


            string trazena_osoba_ime = (
                from tr_os      // postavimo ime varijable za svaki element kolekcije
                in osobe        // kolekcija iz koje radimo pretragu
                where tr_os.Prezime.Contains("ve")  // filter
                select tr_os.Ime    // selektiramo kompletan element
                ).FirstOrDefault();

            Console.WriteLine("pronasli smo osobu " + trazena_osoba_ime);

            var osobe_ve = (
                from tr_os      // postavimo ime varijable za svaki element kolekcije
                in osobe        // kolekcija iz koje radimo pretragu
                where tr_os.Prezime.Contains("ve")  // filter
                select tr_os.Ime    // selektiramo kompletan element
                ).ToList();

            foreach (var item in osobe_ve)
            {
                Console.WriteLine("pronasli smo osobe na ve " + item);
            }

            var osobe_na = (
            from tr_os      // postavimo ime varijable za svaki element kolekcije
            //in osobe.DefaultIfEmpty(new Osoba { Ime = "Jane", Prezime = "Doe" })        // kolekcija iz koje radimo pretragu
            in osobe        // kolekcija iz koje radimo pretragu
            where tr_os.Ime.Contains("xa")  // filter
            select tr_os.Prezime   // selektiramo kompletan element
            ).ToList().DefaultIfEmpty("Doe");

            foreach (var item in osobe_na)
            {
                Console.WriteLine("Prezime osobe koja u imenu ima 'na'" + item);
            }

            // primjer u array
            string[] niz_osobe_na = (
                from tr_os      // postavimo ime varijable za svaki element kolekcije
                in osobe.DefaultIfEmpty(new Osoba { Ime = "Jane", Prezime = "Doe" }) //  Ne radi, provjeri zasto
                where tr_os.Ime.Contains("xy")  // filter
                select tr_os.Prezime   // selektiramo kompletan element
                ).ToArray();

            Console.WriteLine("Ispis iz niza stringova");
            foreach (var item in niz_osobe_na)
            {
                Console.WriteLine("Prezime osobe koja u imenu ima 'na'" + item);
            }



            //     ---->    PRIMJER DefaultIfEmpty() , hvala Jasmin Medved
            // primjer first ili default
            var osobe_def = (
            from tr_os      // postavimo ime varijable za svaki element kolekcije
            in osobe        // kolekcija iz koje radimo pretragu
            where tr_os.Ime.Contains("xx")  // filter
            select tr_os   // selektiramo kompletan element
            //).FirstOrDefault();
            ).ToList().DefaultIfEmpty(new Osoba { Ime = "Jane", Prezime = "Doe" }).FirstOrDefault();
            Console.WriteLine("pronasli smo defaultnu odsobu: " + osobe_def.Prezime);
        }
    }
}
