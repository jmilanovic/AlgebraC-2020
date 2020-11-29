using System;

namespace _5_1_Umnozak_i_kvocjent
{//program unosi dva cijela broja i racuna njihov umnozak i kvocjent
    class Program
    {
        static void Main(string[] args)
        {
            int broj1, broj2, umnozak;
            double kvocjent;
            Console.WriteLine("Unesi dva cijela broja!");
            Console.WriteLine("Unesi prvi cijeli broj.");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi cijeli broj.");
            broj2 = int.Parse(Console.ReadLine());
            umnozak = broj1 * broj2;
            kvocjent = (double)broj1 / (double)broj2;
            Console.WriteLine("Umnozak je: " + umnozak);
            Console.WriteLine("Kvocjent je: {0}", kvocjent);
        }
    }
}
