/*
 Napišite program Štoperica koji će na pritisak neke tipke početi mjeriti vrijeme. Kad se sljedeći
put pritisne neka tipka, program će ispisati koliko je vremena proteklo.
 */
using System;

namespace Štoperica_12_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pritisni neku tipku!");
            Console.ReadKey();
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Unesite Stop od štoperice kada budete spremni:"); 
            Console.ReadKey();
            
            DateTime d2 = DateTime.Now;
            TimeSpan interval = d2.TimeOfDay - d1.TimeOfDay;
            Console.WriteLine("Prošlo je {0} sati {1} minuta {2} sekundi ", interval.Hours,interval.Minutes,interval.Seconds);

        }
    }
}
