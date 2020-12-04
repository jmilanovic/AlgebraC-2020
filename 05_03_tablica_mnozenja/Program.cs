using System;

namespace _05_03_tablica_mnozenja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
//            0 1 2 3 4 ...
//            1
//            2 2 4
//            3
/*
 *  Iteratore pisemo kao:
 *  lowercase (malaslova) i, j, k
 *  kombinacije  ii, jj, kk, iii , 
 *  i2,i3....
 * */
            for (int i = 1; i <= 10; i++)
            {
                for (int j  = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
