using System;

namespace _06_niz_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva");

            int[] ulaz = new int[5];
            int max = int.MinValue;

            for (int i = 0; i < ulaz.Length; i++)
            {
                ulaz[i] = int.Parse(Console.ReadLine());
                if (ulaz[i] >= max) {
                    max = ulaz[i];
                }
            }

            for (int i = 0; i < ulaz.Length; i++)
            {
                if (max == ulaz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ulaz[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else { 
                     Console.Write(ulaz[i] + " ");               
                }
                
            
            }
             



        }
    }
}
