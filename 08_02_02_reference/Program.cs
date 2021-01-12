using System;

namespace _08_02_02_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("po referenci");

            int broj=2;  // osnovni, primarni tip
            
            PovecajZaJedan(broj);  // prosljeden po vrijednosti, znaci kopiranu vrijednost saljemo
            Console.WriteLine(broj);

            PovecajZaJedan1(ref broj);  // prosljeden po refenci, znaci saljemo mem. adresu varijable
            Console.WriteLine(broj);
        }

        private static void PovecajZaJedan1(ref int broj)
        {
            broj++;
        }

        private static void PovecajZaJedan(int broj)
        {
            broj++;
        }
    }
}
