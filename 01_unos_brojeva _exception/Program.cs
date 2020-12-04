using System;

namespace _01_unos_brojeva__exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            Console.WriteLine("Temperatura ledišta je 0 stupnjeva.");
            Console.WriteLine("Temperatura vrelišta je 100 stupnjeva");

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            int prvi=0, drugi=0, zbroj, razlika;

            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                prvi = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugi = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Greška, morate unijeti broj ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: ");
                Console.WriteLine(e.Message);
            }
            zbroj = prvi + drugi;
            razlika = prvi - drugi;

            Console.WriteLine($"Zbroj je {zbroj}, a razlika je {razlika}");


            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            int umnozak;
            float kvocijent;

            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                prvi = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugi = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: ");
                Console.WriteLine(e.Message);
                throw e;
            }

            umnozak = prvi * drugi;
            kvocijent = (float)prvi / drugi;
           // Console.WriteLine("Kvocijent je: {0}", (float)prvi_broj / (float)drugi_broj);
            Console.WriteLine($"Umnožak je {umnozak}, a kvocijent je {kvocijent:F2}");

        }
    }
}
