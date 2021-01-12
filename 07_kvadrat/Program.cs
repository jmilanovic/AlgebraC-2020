using System;

namespace _07_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(Kvadrat(UcitajCijeliBroj()));
            Console.WriteLine(Kvadrat("8"));

            decimal kva = Kvadrat(5);
            Console.WriteLine(kva);


        }

        private static int Kvadrat(string v)
        {
            return Kvadrat(int.Parse(v));
        }

        private static int UcitajCijeliBroj()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int Kvadrat(int v)
        {
            return v * v; 
        }
    }
}
