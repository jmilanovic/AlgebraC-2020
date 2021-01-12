using System;
using System.Collections.Generic;

namespace _06_02_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genericke liste, unesi brojeve, unesi nulu za kraj");
            List<int> listabrojeva = new List<int>();  // iskljucivo prima samo int !!!

            List<int> parni = new List<int>();
            List<int> neparni = new List<int>();


            int broj = -1;
            while (broj!=0) {
                  broj=int.Parse(Console.ReadLine());
                //broj = Console.ReadLine();
                listabrojeva.Add(broj);
            }

            foreach (var item in listabrojeva)
            {
                Console.Write(item+" ");
            }
            foreach (var item in listabrojeva)
            {
                if (item % 2 == 0)  //parni
                {
                    parni.Add(item);
                }
                else
                {
                    neparni.Add(item);
                }
            }

            Console.WriteLine("Parni:");
            foreach (var item in parni)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("Neparni:");
            foreach (var item in neparni)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("Sortirani neparni:");
            neparni.Sort();
            foreach (var item in neparni)
            {
                Console.Write(item + " ");
            }

        }
    }
}
