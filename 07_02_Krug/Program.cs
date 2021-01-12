using System;

namespace _07_02_Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radijus");

            double radijus = double.Parse(Console.ReadLine());

            decimal povrsina = IzracunajPovrsinu(radijus);
            double opseg = IzracunajOpseg(radijus);

            Console.WriteLine("Za radijus {0}, povrsina je {1}, a opseg je {2}", radijus, povrsina, opseg);
        }

        private static double IzracunajOpseg(double radijus)
        {
            double rezultat = 2 * radijus * Math.PI;
            return rezultat;
        }

        private static decimal IzracunajPovrsinu(double radijus)
        {
            double rezultat =radijus * radijus * Math.PI;
            return Convert.ToDecimal(rezultat);
        }
    }
}
