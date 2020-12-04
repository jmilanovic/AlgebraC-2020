using System;

namespace _05_logicki_NOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime skole (Algebra)");

            string imeskole = Console.ReadLine().ToLower();

            if (!(imeskole == "algebra"))  // primjeti negaciju, usklicnik
            {
                Console.WriteLine("Upisi Algebry");
            }
            else {
                Console.WriteLine("Sve OK");
            }
        }
    }
}
