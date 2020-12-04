using System;

namespace _05_03_suma_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("racunam sumu i prosjek");
            Console.WriteLine("Unosi brojeve, za kraj unesi nulu");
            
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
                sumaBrojeva += ulazniBroj;
                brojaBrojeva++;
            }
            Console.WriteLine("Suma je {0}, a prosjek {1:F3}",sumaBrojeva,(float)sumaBrojeva/brojaBrojeva);
        }
    }
}
