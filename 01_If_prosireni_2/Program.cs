using System;

namespace _01_If_prosireni_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj:");
            int broj = int.Parse(Console.ReadLine());

            //Proširena if naredba
            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan.");
            }
            else if (broj < 0)
            {
                Console.WriteLine("Broj je negativan.");
            }
            else
            {
                Console.WriteLine("Nula !!!");
            }

            //Nested if
            if (broj > 0)
            {
                Console.Write("Pozitivan");
            }
            else
            {
                if (broj < 0)
                {
                    Console.WriteLine("Negativan");
                }

                else
                {
                    Console.WriteLine("Nula (Zero)");
                }

            }

            Console.ReadKey();

            //5.2.2
            //Kalkulator sa osnovnim operacijama (+,-)
            //Traži unos 2 broja, a zatim unos operacije
            //Rezultate ispisuje ukonzolni prozor.
            //Ako je odabrana nepodržana operacija, ispisuje
            //"Operacija nije podržana"



        }
    }
}
