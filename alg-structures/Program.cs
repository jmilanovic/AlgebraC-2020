using System;

namespace alg_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer strukture");

            Predmet p1 = new Predmet();
            Predmet p2 = new Predmet("Kemija",6);

            p1.Naziv = "Matematika";
            p1.ECTS = 7;

            Profesor prof = new Profesor("Pero", 5700, "Math");
            
            p1.prof = prof;

            Console.WriteLine(prof);
            Console.WriteLine(p1);

            // https://medium.com/csharp-architects/whats-faster-in-c-a-struct-or-a-class-99e4761a7b76

            StructsTest st1 = new StructsTest();
            st1.Iterations = 100;
            st1.MeasureTestA();
            st1.MeasureTestB();
            st1.MeasureTestC();


        }
    }
}
