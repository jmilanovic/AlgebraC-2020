using System;

namespace vježba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Now="+d1);
            Console.WriteLine("d1.Date="+d1.Date);
            Console.WriteLine("d1.ToShortDataString=" + d1.ToShortDateString());
            Console.WriteLine("d1.ToLongDataString=" + d1.ToLongDateString());
            Console.WriteLine("d1.ToShortTimeString=" + d1.ToShortTimeString());
            Console.WriteLine("d1.ToLongTimeString=" + d1.ToLongTimeString());
            Console.WriteLine("d1.Year=" + d1.Year);
            Console.WriteLine("d1.Minute=" + d1.Minute);
            Console.WriteLine("d1.AddDays(3)=" + d1.AddDays(3));
            Console.WriteLine("d1.AddHour(3)=" + d1.AddHours(3));
            Console.WriteLine("d1.AddHour(3).ToLongTimeString=" + d1.AddHours(3).ToLongTimeString());

            Console.WriteLine("Unesite datum:");
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(d2);
            Console.WriteLine(d2.ToShortDateString());

            Console.WriteLine("Ovo je TimeSpan");
            TimeSpan interval = d2 - d1;
            Console.WriteLine(interval);
            Console.WriteLine(interval.Days);
            Console.WriteLine(interval.Hours);
            Console.WriteLine(interval.TotalDays);

        }
    }
}
