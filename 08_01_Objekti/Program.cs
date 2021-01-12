using System;

namespace _08_01_Objekti
{
    class Program
    {
        private static string Prezime;

        static void Main(string[] args)
        {
            // Kreitrmo Ucenika
            Console.WriteLine("Novi ucenik:");

            //tip  //var //new  //konstruktor()
            Ucenik uc1 = new Ucenik();   //defaultni konstruktor 

            Console.WriteLine("Unesite ime ucenika:");
            uc1.Ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime ucenika:");
            uc1.Prezime= Console.ReadLine();

            Console.WriteLine("Unesite ocjenu iz biologije:");
            uc1.OcjenaIzBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz engleskog:");
            uc1.OcjenaIzEngleskog = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz matematike:");
            uc1.OcjenaIzMatematike = int.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek ucenika {0} je: {1}", uc1.Ime, uc1.Prosjek());

            Ucenik uc2 = new Ucenik("Ivo","Jurlina");  // instanciranje klase
            Console.WriteLine("Unesite ocjenu iz biologije:");
            uc2.OcjenaIzBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz engleskog:");
            uc2.OcjenaIzEngleskog = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz matematike:");
            uc2.OcjenaIzMatematike = int.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek ucenika {0} je: {1}", uc2.Ime, uc2.Prosjek());

            Ucenik uc3 = new Ucenik();   //defaultni konstruktor 
            Console.WriteLine("Ucenik {0} {1} je upisan", uc3.Ime, uc3.Prezime );

            Profesor prf1 = new Profesor(Ime:"Jure",Placa:7000, Predmet:"Matematika");
            Profesor prf2 = new Profesor(Ime: "Jana", Predmet: "Kemija", Placa: 17000);

           prf2.Prezime = "einstein";  // Ovo svojstvo ima MUTATOR prvovelikoslovo
            Console.WriteLine("Profesor {0} predaje predmet {1} a preziva se {2}", prf2.Ime, prf2.Predmet, prf2.Prezime1);

            prf2.Prezime1 = "zweinstein"; // Ovo svojstvo nema MUTATOR i prezime ce zapocinjati malim
            Console.WriteLine("Profesor {0} predaje predmet {1} a preziva se {2}", prf2.Ime, prf2.Predmet, prf2.Prezime1);


            Console.WriteLine("Profesor {0} predaje predmet {1} te ima placu {2}", prf1.Ime,prf1.Predmet,prf1.Placa);

        }
    }

    internal class Ucenik
    {
        // svojstva ili properties -> U ovom slucaju ovo su field iliti polja (ne mjesati sa array)
        internal string Ime;
        internal string Prezime;
        internal int OcjenaIzBiologije;
        internal int OcjenaIzEngleskog;
        internal int OcjenaIzMatematike;
        private DateTime DatumNastanka;
/*
        public Ucenik()
        {
            DatumNastanka = DateTime.Now;
        }
*/
        public Ucenik(string Ime="Winko", string Prezime="Rakijic")
        {
            this.Ime = Ime;
            this.Prezime=Prezime;
        }

        internal string Prosjek()
        {
            return ((double)(this.OcjenaIzBiologije 
                + this.OcjenaIzEngleskog 
                + this.OcjenaIzMatematike) / 3).ToString();
        }
    }
}
