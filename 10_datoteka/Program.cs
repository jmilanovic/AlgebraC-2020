using System;
using System.IO;

namespace _10_datoteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite nekakav text");

            string txt = Console.ReadLine();

            //handle koji kreira file i/ili pregazi postojeci
           // FileStream fs1 = new FileStream("Proba.txt", FileMode.Create); //FileStream("Proba.txt", 2);

            // handfle koji dodaje na kraj filea
            FileStream fs1 = new FileStream("Proba1.txt", FileMode.Append); //FileStream("Proba.txt", 6);

            StreamWriter sw1 = new StreamWriter(fs1);

            sw1.WriteLine(txt);

            sw1.Flush();
            sw1.Close();
            fs1.Close();


            // handfle koji dodaje na kraj filea
            FileStream fs2 = new FileStream("Proba1.txt", FileMode.Open); //FileStream("Proba.txt", 3);

            StreamReader sr1 = new StreamReader(fs2);

            string procitano = sr1.ReadToEnd();

            Console.WriteLine(procitano);
            
            sr1.Close();
            fs2.Close();




        }
    }
}
