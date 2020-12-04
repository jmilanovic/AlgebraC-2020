using System;

namespace _05_03_par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unosi brojeve, za kraj unesi nulu");
            int parnih = 0;
            int neparnih = 0;
            int broj = 0;
            while (true)
            {
                broj = int.Parse(Console.ReadLine());
                if (broj==0)
                {
                    break;
                }
                if (broj % 2 == 0) {
                    parnih++;
                }
                else
                {
                    neparnih++;
                }
            }
            Console.WriteLine("Parnih: {0}, neparnih:{1}", parnih,neparnih);

        }
    }
}
