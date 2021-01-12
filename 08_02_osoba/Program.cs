using System;

namespace _08_02_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
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

                Console.WriteLine("Neispravamn unos "+e.Message);
            }

            Console.WriteLine("{3} Ime {0} prewzime {1} starost {2}", os1.Ime, os1.Prezime, os1.Starost, os1.StarostPozdrav);
        }
    }
}
