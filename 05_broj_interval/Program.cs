using System;

namespace _05_broj_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj u intervalu 13 do 24");
            int broj=13;

            try
            {
                broj = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greska, niste unijeli cijeli broj");
            }
            catch (Exception e) {
                Console.WriteLine("Neka opca greska");
            }
            if((broj >=13) && (broj<24) ) // Broj mora biti izmedju 13 i 24, ukljkucujuci 13 ali strogo manje od 24
            {
                Console.WriteLine("Broj je ok");
            }
            else
            {
                Console.WriteLine("Broj mora biti izmedju 13 i 24, ukljkucujuci 13 ali strogo manje od 24");
            }

        }
    }
}
