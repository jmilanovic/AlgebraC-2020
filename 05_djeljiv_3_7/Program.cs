using System;

namespace _05_djeljiv_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj djeljiv sa 3 i sa 7");
            int broj = 0;

            try
            {
                broj = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greska, niste unijeli cijeli broj");
            }
            catch (Exception e)
            {
                Console.WriteLine("Neka opca greska");
            }
            //if ((broj % 3 == 0) && (broj % 7 == 0)) // Broj mora biti djeljiv i sa 3 i sa 7
            if ((broj % 3 == 0) || (broj % 7==0)) // Broj mora biti djeljiv ili sa 3 ili sa 7
            {
                Console.WriteLine("Broj je ok");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv sa 3 i 7");
            }

        }
    }
}
