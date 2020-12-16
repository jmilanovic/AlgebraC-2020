using System;
using System.Collections.Generic;

namespace DZ_Oslobodi_se_parcijalnog
{
    /*
     * 
1. Kreirati objekt Kolac
2. Program:
 - Kreiraj objekt Kolac K1 -> "Cokoladna ekstaza"
 // sastojke dodati u listu unutar kolaca
 - K1.DodajSastojak("Margarin",200) 
 - K1.DodajSastojak("Secer",100)
 - K1.DodajSastojak("Cokolada",300) 
 - K1.DodajSastojak("Jaje",50) //g
 - Rerna.Ispeci(ref K1)   // Staticka klasa rerna, ne moze se instancirati
 - Ponovi sve sa K2

3. Console.Writeline(K1)
 - Ako je kolac pecen ispisi "kolac je pecen" (boolean)
 - Ispisi sastojke
 - Ispisi ukupnu masu kolaca kao zbroj sastojaka ( U KG, NA DVIJE DECIMALE)


4. K1.DodajSastojak("Limun",100)
  - dodaj uvjet, ako je kolac pecen ne dozvoli dodavanje sastojaka

5. Console.Writeline(Rerna.BrojIspecenihKolaca)
     */
    class Program
    {
        static void Main(string[] args)
        {
            string limun;
            string pecenje; 
            Kolac K1 = new Kolac();
            K1.DodajSastojak.Add("Margarin");
            K1.DodajSastojak.Add("200");
            K1.DodajSastojak.Add("Secer");
            K1.DodajSastojak.Add("100");
            K1.DodajSastojak.Add("Cokolada");
            K1.DodajSastojak.Add("300");
            K1.DodajSastojak.Add("Jaje");
            K1.DodajSastojak.Add("50");
            /////////////////////////////////////////////////////////////////
            /////-nekužim ovaj dio zadatka zašto se sve treba ponoviti, a ne ispisati
            Kolac K2 = new Kolac();
            K2.DodajSastojak2.Add("Margarin");
            K2.DodajSastojak2.Add("200");
            K2.DodajSastojak2.Add("Secer");
            K2.DodajSastojak2.Add("100");
            K2.DodajSastojak2.Add("Cokolada");
            K2.DodajSastojak2.Add("300");
            K2.DodajSastojak2.Add("Jaje");
            K2.DodajSastojak2.Add("50");

            List<string> privremena = new List<string>();
        
            foreach (var item in K1.DodajSastojak)
            {
                privremena.Add(item);
            }

            Console.WriteLine("Stavili ste sastojke u 'Rernu' želite li da počnem peči kolač 'Čokoladna ekstaza' (D/N); 'K' za kraj?");
            pecenje = Console.ReadLine().ToLower();
            while (!(pecenje == "d" || pecenje == "n" || pecenje == "k"))
            {
                Console.WriteLine("");
                Console.WriteLine("Krivi unos!");
                Console.WriteLine("Stavili ste sastojke u 'Rernu' želite li da počnem peči kolač 'Čokoladna ekstaza' (D/N); 'K' za kraj?");
                pecenje = Console.ReadLine().ToLower();
            }

            while (pecenje!= "k")
            {
                if (pecenje == "d")
                {
                    privremena.Clear();//brise Limun ako je prethodno unesen (a ne zeli se kolac s limunom)
                    if (K1.DodajSastojak[K1.DodajSastojak.Count - 2] == "Limun")
                    {
                        //       K1.DodajSastojak.Remove("Limun");// Console.WriteLine("uaso");// break;//znači da je Limun od prije već unesen pa ga nemoj unositi još jednom
                        //       K1.DodajSastojak.Remove("100");
                        K1.DodajSastojak.RemoveAt(8);//prvo brise Limun na poziciji 8
                        K1.DodajSastojak.RemoveAt(8);//zatim brise "100" koji je bio na poziciji 9 ali kada se obrisao limun postao je pozicija 8

                    }
                    foreach (var item in K1.DodajSastojak)
                    {
                        privremena.Add(item);
                    }
                    Rerna.Ispeci(ref privremena);
                }
                if (pecenje == "n")
                {
                    Console.WriteLine("Zelite li dodati limun u kolac (D/N)?");
                    limun = Console.ReadLine().ToLower();
                    if (limun == "d")
                    {
                        privremena.Clear();//brise sve sastojke iz Privremenu listu kako bi se mogla unijeti nova lista s limunom
                        if (K1.DodajSastojak[K1.DodajSastojak.Count-2] == "Limun")
                        {
                            ;// Console.WriteLine("uaso");// break;//znači da je Limun od prije već unesen pa ga nemoj unositi još jednom
                        }
                        else
                        {//unesi Limun po prvi put
                            K1.DodajSastojak.Add("Limun");
                            K1.DodajSastojak.Add("100");
                        }
                        foreach (var item in K1.DodajSastojak)
                        {
                            privremena.Add(item);
                        }
                        Rerna.Ispeci(ref privremena);
                    }
                    else if (limun == "n")
                    {
                       // break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Stavili ste sastojke u 'Rernu' želite li da počnem peči kolač 'Čokoladna ekstaza' (D/N); 'K' za kraj?");
                pecenje = Console.ReadLine().ToLower();
                while (!(pecenje == "d" || pecenje == "n" || pecenje == "k"))
                {
                    Console.WriteLine("Krivi unos!");
                    Console.WriteLine("");
                    Console.WriteLine("Stavili ste sastojke u 'Rernu' želite li da počnem peči kolač 'Čokoladna ekstaza' (D/N); 'K' za kraj?");
                    pecenje = Console.ReadLine().ToLower();
                }
            }
            if (pecenje == "k")
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Broj ispecenih kolaca je: {0} komada!", Rerna.BrojIspecenihKolaca);
                Console.WriteLine("Masa ispecenih kolaca je: {0:f2} grama ({1:f2} kg.)!", Rerna.MasaIspecenihKolaca, (double)Rerna.MasaIspecenihKolaca/1000);
            }

        }
    }
}
