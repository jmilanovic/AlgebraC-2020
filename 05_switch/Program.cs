using System;

namespace _05_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prvi broj: ");
            decimal prvi = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Drugi broj: ");
            decimal drugi=0;


            try
            {
                drugi = decimal.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // throw ex;
            }

            Console.WriteLine("Unesite operaciju: ");
            string operacija;

            try
            {
                operacija = Console.ReadLine();
            }
            catch (Exception egreska)
            {

                throw egreska;
            }

            switch (operacija)
            {
                case "P":  // SWITCH FALL THROUGH
                case "p":
                case "+":
                    Console.WriteLine("Zbroj je {0}", prvi + drugi);
                    break;
                case "M":
                case "m":
                case "-":
                    Console.WriteLine("Razlika je {0}", prvi - drugi);
                    break;
                case "*":
                    Console.WriteLine("Umnožak je {0}", prvi * drugi);
                    break;
                case "/":
                    Console.WriteLine("Kvocijent je {0}", prvi / drugi);
                    break;
                default:
                    Console.WriteLine("Nepodržana operacija.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
