using System;

namespace _05__03_01_for_petlja
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++) // Start, Stop, Step --> SSS
            {
                Console.WriteLine("Hello World! " + (i + 1).ToString());
            }

            Console.WriteLine("Parni Brojevi:");
            for (int i = 0; i < 10; i += 2) // Start, Stop, Step --> SSS
            {

                Console.Write(i + " ");
            }
            Console.WriteLine("\nParni Brojevi, drugi nacin:");
            for (int i = 0; i < 10; i =i+ 2) // Start, Stop, Step --> SSS
            {

                Console.Write(i + " ");
            }
            Console.WriteLine("\nParni Brojevi, treci modulo nacin:");
            for (int i = 0; i < 10; i++) // Start, Stop, Step --> SSS
            {
                if(i%2==0)
                Console.Write(i + " ");
            }
            Console.WriteLine("\nParni Brojevi,  modulo nacin unatrag:");
            for (int i = 10; i > 0; i--) // Start, Stop, Step --> SSS
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\nParni Brojevi, cetvrti unatrag sa -- nacin:");
            for (int i = 10; i > 0; i-=2) // Start, Stop, Step --> SSS
            {

                Console.Write(i + " ");
            }
        }
    }
}
