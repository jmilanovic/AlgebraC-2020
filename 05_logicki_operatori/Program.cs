using System;

namespace _05_logicki_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username and pazzz");

            Console.WriteLine("unesi ime (Pero)");
            string uname = Console.ReadLine().ToLower();
            
            Console.WriteLine("unesi pass(123)");
            string pass=  Console.ReadLine();

            if (uname=="pero" && pass == "123")
            {
                Console.WriteLine("Korisnik je logiran");
            }
            else
            {
                Console.WriteLine("Korisnicko ime i/ili pass je neispravan");
            }


        }
    }
}
