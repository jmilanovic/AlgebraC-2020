using System;
using _08_03_vozila;

namespace _08_nova_vozila_s_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo je moja nova sasvim aplikacija za vozni park");

            Automobil a1 = new Automobil(
            Naziv: "Fiat",
            Boja: "Crveni",
            KS: 200,
            Ccm: 2200);
            Console.WriteLine(a1);
        }
    }
}
