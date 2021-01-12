using System;
using System.Collections.Generic;

namespace _06_02_genericke_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> brojevi = new List<int>();

            brojevi.Add(5);
            brojevi.Add(22);


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Molim unesite {0}. broj: ",i+1);
                int broj = int.Parse(Console.ReadLine());
                brojevi.Add(broj);

            }

           // brojevi.Add(22.5);  ne dozvoljava promjenu tipa


            // ispis original
            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.Write("{0} ", brojevi[i]);
            }

            brojevi.Sort();
            // ispis sortirani
            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.Write("{0} ", brojevi[i]);
            }

            brojevi.Reverse();
            // ispis obrnuti
            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.Write("{0} ", brojevi[i]);
            }


            List<string> tekstovi = new List<string>(){
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            List<bool> booliana= new List<bool>(){
                        true,
                        true,
                        true,
                        false
                    };

            Console.WriteLine("ïspis boolean liste");
            foreach (var item in booliana)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("ïspis string liste");
            foreach (var item in tekstovi)
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
