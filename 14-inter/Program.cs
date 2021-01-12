using System;

namespace _14_inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pointovi i interfacei");

            Point p1 = new Point(3,5) ;

            Console.WriteLine("Point "+p1);

            p1.PrintPoint();

            p1.Mojaboja=p1.setBoja("Zelena");

            p1.PrintPoint();

            p1.Mojaboja = p1.setBoja("Black");

            p1.PrintPoint();

            p1.PomakniMeZaX(7);
            p1.PomakniMeZaY(5);

            p1.PrintPoint();  // nakon ove linije se p1 vise ne spominje i mozemo da unistiti (dispose) ili cekati garbage collector

            p1.Dispose();


            Console.WriteLine("Memory used before collection:       {0:N0}",
                        GC.GetTotalMemory(false));

            // Collect all generations of memory.
            
            GC.Collect(); // forsiramo pokretanje GC

            Console.WriteLine("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory(true));
       


            Korisnik k1 = new Korisnik();
            k1.RegistrirajMe("admin");
            Console.WriteLine("moje korisnicko ime je "+k1);


            /////////////  covariance, invariance, contravariance
            Console.WriteLine("covariance, invariance, contravariance ");

            Tocka t1 = new Tocka(5, 8);  // derivi-- deriv

            IPoint t2 = new Tocka(5, 8);  // generalni preko iF

            IPoint t5 = new Point(5, 8, BojaTocke.Roza);  // generalni preko iF

            Point t3 = new Tocka(5, 8);  // baznu --> iz svojstava deriv

            //  Tocka t4 = (Tocka)(new Point(5, 8));  // Neuobicaje no castati iz bazne u deriviranu

            t1.PrintPoint();
            t2.PrintPoint();
            t3.PrintPoint();
            //t4.PrintPoint();
            t5.PrintPoint();

            Console.ReadKey();

        }
    }
}
