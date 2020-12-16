using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_Oslobodi_se_parcijalnog
{
    class Rerna
    {
        private Rerna() { }

        static int brojIspecenihKolaca = 0;
        static int masaIspecenihKolaca = 0;
        
        public static List<string> sastojakKolaca = new List<string>();

        public static object BrojIspecenihKolaca 
        {
            get
            {
                return brojIspecenihKolaca;
            }            
        }

        public static int MasaIspecenihKolaca
        {
            get
            {
                return masaIspecenihKolaca;
            }
        }

        internal static void Ispeci(ref List<string> sastojakKolaca)
        {         
            int masa=0;

            Console.WriteLine("");
            Console.WriteLine("Kolac je pecen!");
                Console.WriteLine("Sastojci koje ste unijeli u kolac su:");
                Console.WriteLine("--------------------------------");

                for (int i = 0; i < sastojakKolaca.Count; i++)
                {
                    Console.WriteLine(sastojakKolaca[i] + ": od " + sastojakKolaca[++i] + " grama");
                    masa += Convert.ToInt32(sastojakKolaca[i]);
                }
            Console.WriteLine("Ukupna masa kolaca je: {0:f2} grama", masa);

            brojIspecenihKolaca =brojIspecenihKolaca+1;
            masaIspecenihKolaca = masaIspecenihKolaca + masa;
               

            sastojakKolaca.Clear();
           
        }
    }
}
