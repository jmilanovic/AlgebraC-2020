using System;

namespace _07_potprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozdrav iz Main metode");
            
            Hello();
            Hello();
            Hello();
            Hello();

            Pozdrav("Jurica");
            Pozdrav("Ana", "Banmana");
            Pozdrav("Marica",7);
            Kraj();
            /*
            Program p1 = new Program();
            p1.Hello(); 
            */
        }
        //public void Hello()
        //{

        //    Console.WriteLine("Pozdrav iz potprograma HELLO");
        //}
        static void Hello()
        {
            Console.WriteLine("Pozdrav iz potprograma HELLO");
        }

        static void Kraj()
        {
            Console.WriteLine("Pritisni bilo koju tipku za kraj");
            Console.ReadKey();
        }
        static void Pozdrav(string ime)
        {
            Console.WriteLine("Dobar dan {0}",ime);
        }
        static void Pozdrav(string ime, string prezime)
        {
            Console.WriteLine("Dobar dan {0} {1}", ime, prezime);
        }
        static void Pozdrav(string ime, int koliko)
        {
            Console.WriteLine("\nOvo ispisujem {0} puta",koliko);
            for (int i = 0; i < koliko; i++)
            {
                Pozdrav(ime);
             //   Console.WriteLine("{0}: Dobar dan {1}",i+1, ime);
            }
            
        }
    }
}
