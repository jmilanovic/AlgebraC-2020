using System;

namespace _05_par_nepoar_bimbam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("par nepar, unesi broj");
            float broj = 0;

            try
            {
                broj = float.Parse(Console.ReadLine());

                if ((broj % 2 == 0)) // Broj je paran
                {
                    Console.WriteLine("Broj je paran");
                }
                else
                {
                    Console.WriteLine("Broj je neparan");
                }
                if ((broj % 3 == 0)) // Broj je paran
                {
                    Console.WriteLine("Broj je djeljiv sa 3");
                }
                else
                {
                    Console.WriteLine("Broj nije djeljiv sa 3");
                }

                Console.WriteLine("Ostatak kod djeljenja s 3 je:{0:F2}", (broj % 3));



            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greska, niste unijeli cijeli broj");
            }
            catch (Exception e)
            {
                Console.WriteLine("Neka opca greska");
            }

          



        }
    }
}
