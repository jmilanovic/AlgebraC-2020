using System;
using System.IO;

namespace _10_Fileovi_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trenutno smo u direktoriju: ");
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("Ime stroja: ");
            Console.WriteLine(Environment.MachineName);

            Console.WriteLine("Proba postoji li file Proba.txt ");

            string putanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");


            // provjera postoji li file
            if (File.Exists(putanja))
            {
                Console.WriteLine("File Proba.txt postoji!");
            }
            else {
                Console.WriteLine("File Proba.txt NE postoji!");
            }


            // kreiranje direktorija
            if (!Directory.Exists("Proba"))
            {
                Directory.CreateDirectory("Proba");
            }

            // izlistanje direktorija
            Console.WriteLine("Izlistavam C:");

            // string[] dirs = Directory.GetDirectories(@"C:\");  // @ znaci da prihvati doslovno ovakav string bez 
            string[] dirs = Directory.GetDirectories(Environment.CurrentDirectory);
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // string[] dirs = Directory.GetDirectories(@"C:\");  // @ znaci da prihvati doslovno ovakav string bez 
            string[] files = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (var item in files)
            {

          
            //C:\Users\Algebra\Source\Repos\AlgebraC-2020\AlgebraC-2020\10_Fileovi_datoteke\bin\Debug\netcoreapp3.1\Proba
            //C: \Users\Algebra\Source\Repos\AlgebraC - 2020\AlgebraC - 2020\10_Fileovi_datoteke\bin\Debug\netcoreapp3.1\10_Fileovi_datoteke.deps.json
            //    Console.WriteLine(item);



                //10_Fileovi_datoteke.deps.json
                //10_Fileovi_datoteke.dll
                Console.Write(Path.GetFileName(item));
                Console.WriteLine("   EXTENZIJA:"+Path.GetExtension(item));
            }


        }
    }
}
