using System;

namespace _05_03_svi_savrse_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("svi savrseni brojevi do 1000");


            // SAVRSENI BROJ
            //  https://www.enciklopedija.hr/natuknica.aspx?id=54771
            //  6, 28, 496 i 8128. Grčki matematičar Arhita iz Tarenta

            int brojacDjeljitelja = 0;
            int savrsenBroj = 0;
            for (int j = 0; j < 10000; j++)
            {
                brojacDjeljitelja = 0;
                savrsenBroj = 0;
                for (int i = j; i >= 1; i--)
                {
                    if (j % i == 0)
                    {
                        brojacDjeljitelja++;
                        savrsenBroj += i;  // savrsen broj je onaj cija suma djeljitelja je jednaka njemu samom
                                           //Console.Write(i + " ");
                    }

                }
                //Console.WriteLine("\nUkupno ima {0} djeljitelja", brojacDjeljitelja);
                if (j == savrsenBroj - j)
                {
                    Console.WriteLine("\nBroj {0} je savrsen jer je zbroj djeljitelja {1}", j, savrsenBroj - j);
                }
                else
                {
                  //  Console.WriteLine("\nBroj {0} nije savrsen jer je zbroj djeljitelja {1}", j, savrsenBroj - j);
                }
            }


        }
    }
}
