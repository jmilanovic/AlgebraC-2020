using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_imena_a_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi imena, za kraj unesi x ili X");

            List<Auto> automobili = new List<Auto>();

            string ime = "";
            while (ime != "x")
            {
                ime=Console.ReadLine().ToLower();
                automobili.Add(new Auto(ime));
            }

            List<Auto> auto_s_a = (from autic in automobili
                                   where autic.Naziv.ToLower().Contains("a")
                                   select autic).ToList();

            foreach (var item in auto_s_a)
            {
                Console.WriteLine(item.Naziv+", ");
            }

            // okrenuta lista

            List<Auto> auto_s_a_okrenuto = (from autic in automobili orderby autic.Naziv descending
                                   where autic.Naziv.ToLower().Contains("a")
                                   select autic).ToList();

            foreach (var item in auto_s_a_okrenuto)
            {
                Console.WriteLine(item.Naziv + ", ");
            }

        }
    }
}
