using System;

namespace _05_03_svi_djeljitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj, vracam djeljitelje:");
            int nekibroj = 0;
            try
            {
                nekibroj = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("nije broj" + e.Message);
            }

            // SAVRSENI BROJ
            //  https://www.enciklopedija.hr/natuknica.aspx?id=54771
            //  6, 28, 496 i 8128. Grčki matematičar Arhita iz Tarenta

            int brojacDjeljitelja = 0;
            int savrsenBroj = 0;
            for (int i = nekibroj; i >= 1; i--)
            {
                if (nekibroj % i == 0)
                {
                    brojacDjeljitelja++;
                    savrsenBroj += i;  // savrsen broj je onaj cija suma djeljitelja je jednaka njemu samom
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\nUkupno ima {0} djeljitelja", brojacDjeljitelja);
            if (nekibroj== savrsenBroj- nekibroj) {
                Console.WriteLine("\nBroj {0} je savrsen jer je zbroj djeljitelja {1}", nekibroj, savrsenBroj- nekibroj);
            }
            else {
                Console.WriteLine("\nBroj {0} nije savrsen jer je zbroj djeljitelja {1}", nekibroj, savrsenBroj- nekibroj);
            }
        }
    }
}
