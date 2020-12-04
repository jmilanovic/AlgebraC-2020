using System;

namespace _05_03_13_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 brojeva");

            int maxbroj=int.MinValue;  // trebamo postaviti na najmanju mogucu vrijednost uopce!
            int minbroj=int.MaxValue;  // trebamo postaviti na najvecu mogucu vrijednost uopce!
            int ulazniBroj;

            int broj = 10;
            while (broj>0)
            {
                ulazniBroj=int.Parse(Console.ReadLine());
                if (ulazniBroj<minbroj)
                {
                    minbroj = ulazniBroj;
                }
                if (ulazniBroj > maxbroj)
                {
                    maxbroj = ulazniBroj;
                }
                broj--;
            }
            Console.WriteLine("Najmanji broj je {0}, a najveci je: {1}",minbroj,maxbroj);
        }
    }
}
