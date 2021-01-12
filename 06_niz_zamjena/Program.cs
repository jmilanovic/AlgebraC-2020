using System;

namespace _06_niz_zamjena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva");

            int[] ulaz = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;

            int maxposition = 0; int minposition = 0;

            for (int i = 0; i < ulaz.Length; i++)
            {
                ulaz[i] = int.Parse(Console.ReadLine());
                if (ulaz[i] >= max)
                {
                    max = ulaz[i];
                    maxposition = i;
                }
                if (ulaz[i] <= min)
                {
                    min = ulaz[i];
                    minposition = i;
                }
            }

            // zamjena vrijednosti
            int temp = ulaz[minposition];
            ulaz[minposition] = ulaz[maxposition];
            ulaz[maxposition] = temp;

            for (int i = 0; i < ulaz.Length; i++)
            {
                if (max == ulaz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ulaz[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (min == ulaz[i]) {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(ulaz[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(ulaz[i] + " ");
                }


            }
        }
    }
}




