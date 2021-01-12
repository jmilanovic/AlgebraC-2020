using System;
using System.Collections.Generic;

namespace _06_02_01_znamenke_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cjelobrojni broj");
            List<int> znamenke = new List<int>();

            int broj = int.Parse(Console.ReadLine());

            string broj2text = broj.ToString();

            //float decimalni = 0;

            while (broj>0)
            {
                znamenke.Add(broj % 10);  // 123 /10 = 12 --> ostatak je 3 
                broj = broj /= 10;
            }

            Console.WriteLine("\nZbog nacina unosa, znamenke su vec okrenute:");
            foreach (var item in znamenke)
            {
                Console.Write("{0} ", item);
            }
            znamenke.Reverse();

            Console.WriteLine("u ispravnom redosljjedu");
            foreach (var item in znamenke)
            {
                Console.Write("{0} ",item);
            }

            /* PSEUDOCODE
             * 
             * (1) unesi broj     --> 123
             * (1.1) nacini %10
             * (2) podjeli ga s 10   -->12.3
             * (3) znamenku iza decimale spremi u listu
             * (3.1) Loop  dok god ne dodjes do 0
             * (4) reverse
             * (5) ispis
             * */

            // Prijedlog Marko
            //
            Console.WriteLine("\n Marko string char lista:");

            List<char> datalist = new List<char>();
            datalist.AddRange(broj2text);

            foreach (var item in datalist)
            {
                Console.Write("{0} ", item);
            }
            datalist.Reverse();
            Console.WriteLine("\n Marko string okrenuta char lista:");
            foreach (var item in datalist)
            {
                Console.Write("{0} ", item);
            }


        }
    }
}
