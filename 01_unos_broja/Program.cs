using System;

namespace _01_unos_broja
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;//deklaracija cjelobrojne varijable

            broj = 15;
            //ovo neće raditi jer "15" nije broj, nego tekst
            //broj = "15";

            Console.WriteLine(broj);

            try
            {
                broj = int.Parse(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Niste unijeli broj");
            }
            

            Console.WriteLine("Upisali ste broj {0:F2}.", broj);

            string tekst = Console.ReadLine();

            Console.WriteLine("Upisali ste tekst: {0}", tekst);
        }
    }
}
