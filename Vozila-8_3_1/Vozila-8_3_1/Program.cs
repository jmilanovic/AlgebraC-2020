using System;
using System.Collections;
using System.Collections.Generic;

namespace Vozila_8_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AutoBrodList = new ArrayList();
            Console.WriteLine("Želite li unositi auto ili brod (d/n)");
            string unos = "";
            try
            {
                unos = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom unosa: "+ex.Message);
            }
            string auto_brod="", naziv="",boja="";
            int ks=0;
            double ccm=0;
            while (unos == "d")
            {
                Automobil unos_auto = new Automobil();
                Brod unos_brod = new Brod();
                Console.WriteLine("Želite li unijeti auti(A) ili brod");
                auto_brod = Console.ReadLine().ToLower();
                if (auto_brod=="a")
                {
                    Console.WriteLine("Unesite naziv: ");
                    unos_auto.Naziv = Console.ReadLine();
                    Console.WriteLine("Unesite boju: ");
                    unos_auto.Boja = Console.ReadLine();
                    Console.WriteLine("Unesite KS: ");
                    unos_auto.Ks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite Ccm: ");
                    unos_auto.Ccm = double.Parse(Console.ReadLine());

                    unos_auto.KStoKW(ks);

                    AutoBrodList.Add(unos_auto);
                   
                    Automobili auto_sadrzaj = new Automobili();
                    auto_sadrzaj.Add(unos_auto);
                    
                }
                if (auto_brod == "b")
                {
                    Console.WriteLine("Unesite naziv: ");
                    unos_brod.Naziv = Console.ReadLine();
                    Console.WriteLine("Unesite boju: ");
                    unos_brod.Boja = Console.ReadLine();
                    Console.WriteLine("Unesite KS: ");
                    unos_brod.Ks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite Ccm: ");
                    unos_brod.Istisnina = double.Parse(Console.ReadLine());

                    
                    AutoBrodList.Add(unos_brod);
                }
                Console.WriteLine("Želite li unositi auto ili brod (d/n)");
                unos = Console.ReadLine();
            }

            
            foreach (var item in AutoBrodList)
            {
                // Automobil vozilo = (Automobil)item;//mora se castati zato što je u ArrayListi objekt
                // Console.WriteLine("Vozilo: "+vozilo.Naziv+" Boja: "+vozilo.Boja+" Ks: "+vozilo.Ks+" CCm: "+vozilo.Ccm);
                Vozilo vozilo = (Vozilo)item;
                // Brod vozilo2 = (Brod)item;
                
                Console.WriteLine("Vozilo: " + vozilo.Naziv + " Boja: " + vozilo.Boja + " Ks: " + vozilo.Ks + " KSuKW: " + vozilo.KStoKW(vozilo.Ks));// +" CCm: " + vozilo.Ccm);
               // Console.WriteLine("Vozilo: " + vozilo2.Naziv + " Boja: " + vozilo2.Boja + " Istisnina: " + vozilo2.Istisnina);
            }

            Automobili auto_sadrzaj2 = new Automobili();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Vrijednosti samo za auto iz Lits<Automobili>");
            foreach (var item in auto_sadrzaj2.auti)
            {
                // Automobil vozilo = (Automobil)item;//mora se castati zato što je u ArrayListi objekt
                // Console.WriteLine("Vozilo: "+vozilo.Naziv+" Boja: "+vozilo.Boja+" Ks: "+vozilo.Ks+" CCm: "+vozilo.Ccm);
                // Brod vozilo2 = (Brod)item;
                //Console.WriteLine("Vozilo: " + item.Naziv + " Boja: " + item.Boja + " Ks: " + item.Ks + "KSuKW: " + item.KStoKW(item.Ks));// +" CCm: " + vozilo.Ccm);                                                                                                                                                    // Console.WriteLine("Vozilo: " + vozilo2.Naziv + " Boja: " + vozilo2.Boja + " Istisnina: " + vozilo2.Istisnina);
                Console.WriteLine(item);
            }
        }
    }
}
