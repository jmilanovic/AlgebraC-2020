using System;

namespace DZ_4_1_5_1_Uvod_Varijable
{
    /*
     Ovo je program koji ispisuje vrelište i ledište vode na nekoliko načina
     */
    class Program
    {

        static void Main(string[] args)
        {
            //Ispis preko konzole
            // int lediste = 0;
            // int vreliste = 100;

            // Console.WriteLine("Ledište vode je: {0}C",lediste);
            // Console.WriteLine("Vreliste vode je: {0}C",vreliste);

            //Ispis preko klase
            Vreliste v = new Vreliste();
            //unos ledista preko objekta
            v.lediste = 0;
            //unos vreista preko metode
            v.UnesiVreliste(100);
            Console.WriteLine(v);

        }
    }
}
