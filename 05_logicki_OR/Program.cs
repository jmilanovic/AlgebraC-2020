using System;

namespace _05_logicki_OR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Direktor");

            Console.WriteLine("unesi ime (Tomislav, Mislav ili Hrvoje)");
            string uname = Console.ReadLine().ToLower();



            if (uname == "tomislav" || uname == "mislav" || uname == "hrvoje")
            {
                Console.WriteLine("Dobar dan Direktore");
            }
            else
            {
                Console.WriteLine("Skartiraj se, nebitan si...");
            }


        }
    }
}
