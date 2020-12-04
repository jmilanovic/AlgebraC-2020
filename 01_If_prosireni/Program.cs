using System;

namespace _01_If_prosireni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testiranje logičkog izraza
            if (10 > 9)
            {
                //Ovaj blok se izvršava samo ako 
                //je logički uvjet zadovoljen
                Console.WriteLine("Istina");
            }
            else
            {
                //else blok se izvršava ako logički uvjet
                //nije zadovoljen
                Console.WriteLine("Lažeš !!!");
            }

            //primjer 1
            Console.WriteLine("Unesite korisničko ime:");
            string korIme = Console.ReadLine();
            if (korIme == "polaznik")
            {
                Console.WriteLine("Uspješno ste se prijavili.");
            }
            else
            {
                Console.WriteLine("Krivo korisničko ime.");
            }

            //Primjer 2
            Console.WriteLine("Unesite neki broj:");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 10)//if blok je obavezan
            {
                Console.WriteLine("Broj je veći od 10.");
            }
            //else //Else blok nije obavezan
            //{

            //}


            Console.ReadKey();
        }
    }
}
