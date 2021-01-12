using System;
using System.Collections;

namespace _06_02_01_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi eleemnte niza");

            ArrayList arr = new ArrayList();  // ne motramo definirati duljinu liste

            for (int i = 0; i < 5; i++)
            {
                //  arr.Add(int.Parse(Console.ReadLine())); // Jeli potrebno prewbaciti ovo u broj?
                arr.Add(Console.ReadLine()); // Jeli potrebno prewbaciti ovo u broj?
            }

            foreach (var item in arr)
            {
               // Console.Write(" "+ (int.Parse((string)item) * 2));   // moze i ovako
                Console.Write(" " + (int.Parse(item.ToString()) * 2));
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(" " + (int.Parse(arr[i].ToString()) * 2));
            }
        }
    }
}
