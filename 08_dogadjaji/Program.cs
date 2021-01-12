using System;

namespace _08_dogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba();
            Osoba o2 = new Osoba();

            o1.Ime = "Hannibal";

            //funkcija_nakoju_pokazuje mora imati isti POTPIS kao delegat
            //objekt.event     +=  delegat(funkcija_nakoju_pokazuje)
            o1.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);

            o2.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);

            o2.Ime = "Julije";

            o1.Ime = "Alex Makedonski";

            o1.Ime = "Octavian";
        }

        // ovo je akcija ili funkcija na koju pokazuje delegat
        private static void osoba_NaPromjenuImena(object sender, EventArgs e)
        {
            Console.WriteLine("Osoba je promjenila podatke, sada se zove {0}", ((Osoba)sender).Ime);
        }
    }
}
