using System;

namespace _08_04_Staticka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // zbroj,kub, udaljenosttocaka, celcijFar
            
         //   Statika s1 = new Statika();  // Ovo ne zelim!

            //Staticki zbroj
            Console.WriteLine("Zbroj 2 i 3 je "+Statika.Zbroj(prvi_broj:2,drugi_broj:3));

            // staticki kub
            Console.WriteLine("Zbroj 2 i 3 je " + Statika.Kub(broj: 2));

            Statika.Tocka A= new Statika.Tocka(x:0, y:0);
            Statika.Tocka B= new Statika.Tocka(x: 3, y: 4);
            Statika.Tocka C = new Statika.Tocka(x: 2, y: 7);

            // staticki udaljenost tocaka EUKLIDSKA UDALJENOST
            Console.WriteLine("Udaljenost tocaka (0,0) i (3,4) je " + Statika.Udaljenost2D(A,B));

            Console.WriteLine(A);
            A.IdiGore(5);
            Console.WriteLine(A);
            A.IdiDesno(3);
            Console.WriteLine(A);

            Console.WriteLine("Udaljenost tocaka (0,0) i (3,4) je " + Statika.Udaljenost2D(A, B));

            Statika.Duljina D1 = new Statika.Duljina(A:A,B:B);
            Statika.Duljina D2 = new Statika.Duljina(A,C);


            Console.WriteLine(D2);

            A.IdiLijevo(1);
            
            Console.WriteLine(D2);

        }
    }
}
