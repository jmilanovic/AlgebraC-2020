using System;


// SUBSCRIBER



namespace _08_dogadjaji_veci
{
    class Program
    {

        /// <summary>
        /// Kada se promijeni prezime, treba 
        /// ispisati: " Prezime {0} je promijenjeno u {1}"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Osoba oso = new Osoba();
            oso.PromijenjenoPrezime += PromjenaPrezimenaHandler;  //nakacio akciju na event
            oso.PozvanaMetodaPunoIme += PozvanaMetodaPunoIme;
            oso.Ime = "Mirko";
            //1. postavljanje prezimena. Ne okida se event
            oso.Prezime = "Spirko";
            //2. Mijenjamo prezime => uvjet je da 
            //prijašnje prezime nije bilo prazno i 
            //da je novo prezime različito od prethodnog
            oso.Prezime = "Fodor";

            oso.PromijenjenoPrezime -= PromjenaPrezimenaHandler; //otkacio akciju s eventa
            oso.Prezime = "Todor";


            string punoIme = oso.PunoIme();
            Console.WriteLine("Puno ime je:" + punoIme);
            /*
            //Preptplata na event Polaznika...
            Polaznik polo = new Polaznik();
            //5. Pretplata na event => Dajemo ime metodi koja će hendlati događaj
            polo.DodjelaPOEvent += DodjelaProgramaObrazovanjaHandler;

            polo.ProgramObrazovanja = "ASP.NET";
*/
            Console.ReadKey();

        }
        //6.Hendlanje događaja => Metoda koja ima isti potpis kao i delegat 
        static void DodjelaProgramaObrazovanjaHandler(string dodijeljeniPO)
        {
            Console.WriteLine("Polaznika ste upisali u PO:{0}", dodijeljeniPO);
        }

        static void PromjenaPrezimenaHandler(string staro, string novo)
        {
            Console.WriteLine("Prezime {0} je promijenjeno u {1}",
                staro, novo);
        }


        private static void PozvanaMetodaPunoIme()
        {
            Console.WriteLine("Netko je pozvao puno ime.");
        }
    }
}
