using System;

namespace _01_umnozak_kvocijent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prvi: ");
            int prvi = int.Parse(Console.ReadLine());

            Console.WriteLine("Drugi: ");
            int drugi = int.Parse(Console.ReadLine());

            int umnozak = prvi * drugi;
            decimal kvocijent = (decimal)prvi / drugi;

            Console.WriteLine("Umnožak:" + umnozak);
            Console.WriteLine("Kvocijent:" + Math.Round(kvocijent, 4));

            Console.ReadKey();
        }
    }
}
