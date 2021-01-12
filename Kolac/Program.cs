using System;
using System.Collections.Generic;

namespace Kolac
{
    class Kolac
    {
        public Kolac(string ime)
        {
            this.ime = ime;
        }

        //Dodavanje sastojka u listu
        public void DodajSastojak(string imeSastojka, int gramaza)
        {
            if (ispecen != true)  //uvijet da se ne mogu dodavati sastojci u vec pecen kolac
            {
                sastojci.Add(imeSastojka); //TODO ispravi u novi objekt....
                sastojci.Add(gramaza);
            }
            else
            {
                Console.WriteLine("Kolac je ispecen, nemozete nadodati novi sastojak.\n");
            }
        }

        //Accessor
        public bool Ispecen() { 
            return ispecen; 
        }
        public string Ime() { 
            return ime; 
        }

        //Modifier
        public void Ispecen(bool ispecen) { 
            this.ispecen = ispecen; 
        }

        //Variable i liste
        public List<object> sastojci = new List<object>();
        string ime;
        bool ispecen = false;
    }

    static class Rerna
    {
        public static void Ispeci(ref Kolac K)
        {
            if (K.Ispecen() != true)
            {
                K.Ispecen(true);
                Console.WriteLine("Kolac je pecen.");
                Console.WriteLine("Sastojci u kolacu:");
                for (int i = 0; i < K.sastojci.Count; i += 2)
                {
                    Console.WriteLine("Sastojak: {0} | Gramaza: {1}g", K.sastojci[i], K.sastojci[i + 1]);
                }

                double ukupnaGramaza = 0;
                for (int i = 1; i < K.sastojci.Count; i += 2)
                {
                    ukupnaGramaza += Convert.ToInt32(K.sastojci[i]);
                }
                ukupnaGramaza /= 1000;
                Console.WriteLine("Ukupna masa kolaca je: {0}kg\n", ukupnaGramaza);
                brojIspecenihKolaca++;
            }
            else
            {
                Console.WriteLine("Kolac je vec pecen.");
            }
        }

        static public int BrojIspecenihKolaca() { return brojIspecenihKolaca; }
        static int brojIspecenihKolaca = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kolac K1 = new Kolac("Cokoladna ekstaza");
            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Secer", 100);
            K1.DodajSastojak("Cokolada", 300);
            K1.DodajSastojak("Jaje", 50);
            Console.WriteLine("Ime kolaca: {0}", K1.Ime());
            Rerna.Ispeci(ref K1);

            Kolac K2 = new Kolac("Cokoladna ekstaza 2");
            K2.DodajSastojak("Margarin", 200);
            K2.DodajSastojak("Secer", 100);
            K2.DodajSastojak("Cokolada", 300);
            K2.DodajSastojak("Jaje", 50);
            Console.WriteLine("Ime kolaca: {0}", K2.Ime());
            Rerna.Ispeci(ref K2);

            K1.DodajSastojak("Limun", 100);

            Console.WriteLine("Broj ispecenih kolaca je: {0}", Rerna.BrojIspecenihKolaca());
        }
    }
}
