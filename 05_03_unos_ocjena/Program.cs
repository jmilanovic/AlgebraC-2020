using System;

namespace _05_03_unos_ocjena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Racunam sumu i prosjek ocjena");
            Console.WriteLine("Unosi ocjene, za kraj unesi nulu");

            int ulazniBroj = 0;
            int sumaBrojeva = 0;
            int brojaBrojeva = 0;

            while (true) // Ovo je vrlo opasna petlja, moramo imati trigger
            {
                ulazniBroj = int.Parse(Console.ReadLine());
                if (ulazniBroj == 0)  // Okidac iliti trigger za break
                {
                    break;
                }
                if (ulazniBroj<2) {
                    Console.WriteLine("Uspjeh je nedovoljan!");
                    brojaBrojeva = 0;
                    break;
                }
                sumaBrojeva += ulazniBroj;
                brojaBrojeva++;
            }
            if (brojaBrojeva>0)
            {
                Console.WriteLine("Prosjek ocjena je {0:F3}", (float)sumaBrojeva / brojaBrojeva);
            }
            
        }
    }
}
