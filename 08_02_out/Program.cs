using System;

namespace _08_02_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            //Ispisujemo broj
            Ispis(broj);
            
            //Pozivamo metodu sa ByVal parametrom
            Uvecaj(broj);
            
            //Iako smo broj uvećali unutar metode
            //vrijednost varijable u Main metodi ostaje ista
            Ispis(broj);
            
            //Kod poziva funkcije sa ByRef parametrom
            //mijenja se vrijednost originalne varijable
            UvecajPoReferenci(ref broj);
            Ispis(broj);

            Console.WriteLine("Unesite još jedan broj:");
            int drugiBroj;
            string unos = Console.ReadLine();

            bool uspjesnoParsanje = int.TryParse(unos, out drugiBroj);

            Console.WriteLine("Broj je uspjesno parsiran?"+uspjesnoParsanje);
            Ispis(drugiBroj);

            Ispis(broj);

            Console.ReadKey();
        }

        static void Uvecaj(int broj)
        {
            broj++;
        }

        static void UvecajPoReferenci(ref int broj)
        {
            broj++;
        }

        static void Ispis(int broj)
        {
            Console.WriteLine("Iznos broja je {0}", broj);
        }


        // prvi jednostavni primjer iz prirucnika
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("po referenci");

            int broj;  // osnovni, primarni tip

            //PovecajZaJedan1(ref broj);  // prosljeden po refenci, znaci saljemo mem. adresu varijable
            PovecajZaJedan1(out broj);  // prosljeden po refenci, znaci saljemo mem. adresu varijable
            Console.WriteLine(broj);
        }

        private static void PovecajZaJedan1(out int broj)
        {
            broj = 0;
            broj++;
        }
        */
    }
}
