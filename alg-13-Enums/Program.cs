using System;

namespace alg_13_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumeracije");
            Osoba o1 = new Osoba("Markica");
            Console.WriteLine(o1);

            Osoba o2 = new Osoba("Marko", Spol.Muski);
            Console.WriteLine(o2);
            Osoba o3 = new Osoba("Pero", (Spol)1);  // explicitni cast
            Console.WriteLine(o3);
        }
    }
}
