using System;
/*Ovo je jedan primjer gdje se pozivaju varijable koje su u drugoj klasi
  te se istoj klasi šalje neka vrijednost varijable iz druge/osnovne klase 
 */
namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ispiši");

            BojaAuta a1 = new BojaAuta();
            Console.WriteLine(a1);
            a1.boja = "zelena";
            Console.WriteLine(a1);
            //a1.c = "z";
            a1.DodajSnagu(200);
            Console.WriteLine("Konjska snaga nakon ulaska u metodu DodajSnagu je: "+a1.KS);

                



        }
    }
}

namespace Auto1
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ispiši");



        }
    }
}
