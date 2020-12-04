using System;

namespace _05_03_while_beskonac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Za zavrsetak unesi 'kraj'");

            string ime = "";
            while (ime.ToLower() !="kraj")  //Kraj ili kraj
            {
                ime=Console.ReadLine();
                Console.WriteLine("Dobar dan {0}!",ime);

            }

            Console.WriteLine("\nDrugi nacin Za zavrsetak unesi 'kraj'");

            while (true)  //ovo je uvijek true , petlja ide beskonacno
            {
                ime = Console.ReadLine();
                if(ime.ToLower() == "kraj")
                {
                    break;
                }
                Console.WriteLine("Dobar dan {0}!", ime);

            }

        }
    }
}
