using System;

namespace _5_1_Zbroj_i_razlika
{//program racuna zbroj i razliku dva unesena broja
    class Program
    {
        static void Main(string[] args)
        {
            double broj1, broj2, zbroj,razlika;

            Console.WriteLine("Unesi prvi broj:");
            broj1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj:");
            broj2 = double.Parse(Console.ReadLine());
            zbroj = broj1 + broj2;
            razlika = broj1 - broj2;
            // Console.WriteLine("Zbroj je= {0}", "a razlika je= {1}", zbroj, razlika);
            Console.WriteLine("Zbroj je= {0}, a razlika je {1}", zbroj,razlika);
        }
    }
}
