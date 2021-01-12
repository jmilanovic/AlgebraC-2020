using System;
using _08_03_vozila;
using RazneOsobe;

namespace _08_vozila_dll_referenca_na_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo je moja nova sasvim aplikacija uz referencu na projekt 08_03_vozila");

            Automobil a1 = new Automobil(
            Naziv: "Fiat",
            Boja: "Crveni",
            KS: 200,
            Ccm: 2200);
            Console.WriteLine(a1);

            Console.WriteLine("Hello World!");
            Osoba os1 = new Osoba();
            Console.WriteLine("Ime:");
            os1.Ime = Console.ReadLine();
            Console.WriteLine("Prezime:");
            os1.Prezime = Console.ReadLine();

            Console.WriteLine("Starost:");

            try
            {
                os1.Starost = int.Parse(Console.ReadLine());
                Console.WriteLine("Unos je ispravan!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Neispravamn unos " + e.Message);
            }

            Console.WriteLine("{3} Ime {0} prewzime {1} starost {2}", os1.Ime, os1.Prezime, os1.Starost, os1.StarostPozdrav);



        }
    }
}
