using System;

namespace _05_03_djelvo_73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("brojevi djeljivi sa 7 ili s tri");

            for (int i = 0; i < 100; i++)
            {
                if ((i % 7 == 0) || (i % 3 == 0))
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("brojevi djeljivi sa 7 i s tri");

            for (int i = 0; i < 100; i++)
            {
                if ((i % 7 == 0) && (i % 3 == 0))
                {
                    Console.Write(i + " ");
                }

            }


            Console.WriteLine("\nBrojevi djeljivi sa 7 ali ne i s tri");
            int brojacDjeljivih = 0;
            for (int i = 0; i < 100; i++)
            {
                if ((i % 7 == 0) && (!(i % 3 == 0)))
                {
                    brojacDjeljivih++;
                    Console.Write(i + " ");

                }

            }
            Console.WriteLine("\nUkupno ima {0} brojeva koji su djeljivi sa 7 a nisu s 3 izmedju 0-100",brojacDjeljivih);

        }
    }
}
