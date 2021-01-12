using System;
using System.Collections.Generic;

namespace _07_primjermetoda
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Prvi pisemo glavni main program");

            List<int> sviBrojevi = DohvatiSveBrojeve();
            List<int> sviBrojevi2 = DohvatiSveBrojeve2();

            List<int> sviNeparniBrojevi = new List<int>();

            sviNeparniBrojevi = FiltrirajListu(sviBrojevi, false);  //false=neparni

            List<int> sviParniBrojevi = new List<int>();

            sviParniBrojevi = FiltrirajListu(sviBrojevi, true);  //true=parni


            Console.WriteLine("\nIspis svih brojeva");
            ispisiBrojeve(sviBrojevi);

            Console.WriteLine("\nIspis neparnih:");
            ispisiBrojeve(sviNeparniBrojevi);

            Console.WriteLine("\nIspis parnih:");
            ispisiBrojeve(sviParniBrojevi);

        }

        private static void ispisiBrojeve(List<int> sviBrojevi) // potprogrami vracaju void
        {
            foreach (var item in sviBrojevi)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        private static List<int> FiltrirajListu(List<int> sviBrojevi, bool parni) // funkcije vracaju T
        {
            List<int> rezultat = new List<int>();
            foreach (var item in sviBrojevi)
            {

                if (parni)
                {
                    if (item % 2 == 0)
                    {
                        rezultat.Add(item);
                    }

                }
                else {
                    if (item % 2 != 0)
                    {
                        rezultat.Add(item);
                    }

                }
            }
            return rezultat;
        }

        private static List<int> DohvatiSveBrojeve2()
        {
            List<int> brojevi = new List<int>() { 99, 88, 77, 66, 55, 33, 22, 44 }; //pre-definirana lista
            return brojevi;
        }

        private static List<int> DohvatiSveBrojeve()
        {
            List<int> brojevi = new List<int>();
            while (true)
            {
                Console.WriteLine("Unesi broj, za kraj unesi 0");
                int broj = int.Parse(Console.ReadLine());
                if (broj == 0)
                {
                    break;
                }
                brojevi.Add(broj);
            }
            return brojevi;
        }
    }
}
