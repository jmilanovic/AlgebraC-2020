using System;

namespace _12_Datumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rad s datumima!");
            Console.WriteLine("Unesi prvi datum:");
            
            DateTime datum1=DateTime.Now;  // deklaracija van try-catch
            
            try
            {
                 //datum1= DateTime.Parse(Console.ReadLine());   //definiciju
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine(datum1.ToString());

            DateTime datum2 = new DateTime(2021, 1, 1); // nova godina
            Console.WriteLine(datum2.ToLongDateString());
            datum2=datum2.AddHours(-24);

            Console.WriteLine(datum2.ToLongDateString());

            if (datum2 > datum1) {
                Console.WriteLine("Prvi datum je veci od drugog");
            }
            else
            {
                Console.WriteLine("Prvi datum je manji od drugog");
            }
            Console.WriteLine("Ova godina je pristupna? "+DateTime.IsLeapYear(datum1.Year));

            // Primjer timespan vremenskog intervala

            TimeSpan interval = datum1 - datum2;
            Console.WriteLine("interval izmedju {0} i {1} je u danima {2}, ticks:{3}, milisekundi {4} "
                ,datum1.ToShortDateString(), datum2.ToShortDateString(),interval.Days,interval.Ticks, interval.TotalMilliseconds);

        }
    }
}
