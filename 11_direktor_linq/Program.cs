using System;
using System.IO;
using System.Linq;

namespace _11_direktor_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Trenutno smo u direktoriju: ");
            Console.WriteLine(Environment.CurrentDirectory);

            string[] dirs = Directory.GetDirectories(Environment.CurrentDirectory);
            string[] files = Directory.GetFiles(Environment.CurrentDirectory);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
            foreach (var item in files)
            {
                Console.WriteLine(Path.GetFileName(item)+Path.GetExtension(item));
            }

            Console.WriteLine("Unatrag:");

            string[] files_unazad = (from f in files orderby f descending select f).ToArray();
            
            foreach (var item in files_unazad)
            {
                Console.WriteLine(item);
            }


        }
    }
}
