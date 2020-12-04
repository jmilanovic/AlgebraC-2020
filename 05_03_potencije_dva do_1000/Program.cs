using System;

namespace _05_03_potencije_dva_do_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sve potencije broja 2 do 1000");
            int brojTisucu = 1;
            int potencija = 0;

            while (brojTisucu<512)
            {
                potencija++;
                brojTisucu *= 2;
                Console.WriteLine(brojTisucu + " ");
            }

            brojTisucu = 1;
            potencija = 0;
            while (true)
            {
                if (brojTisucu > 511)  // trigger
                {
                    break;
                }
                potencija++;
                brojTisucu *= 2;
                Console.WriteLine(brojTisucu + " ");
            }
        }
    }
}
