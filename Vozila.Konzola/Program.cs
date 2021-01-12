using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Model;

namespace Vozila.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vozilo vz = new Vozilo();

            //ArrayList automobili = new ArrayList();
            //automobili.Add(new Automobil());
            //automobili.Add("Trabant");

            //Automobili auti = new Automobili();
            //auti.Add(new Automobil());
            //auti.Add("Trabant");

            //List<Automobil> genAuti = new List<Automobil>();
            //genAuti.Add(new Automobil());

            List<Vozilo> vozila = new List<Vozilo>();
            List<Automobil> automobili = new List<Automobil>();

            while (true)
            {
                Console.WriteLine("Želite li unositi auto ili brod?(b=brod, a=auto)");
                string vrstaUnosa = Console.ReadLine();

                if (vrstaUnosa.ToLower() == "b")
                {
                    //punimo listu vozila
                    vozila.Add(UcitajBrod());
                }
                else if (vrstaUnosa.ToUpper() == "A")
                {
                    //punimo i vozila i automobile
                    Automobil auto = UcitajAutomobil();
                    vozila.Add(auto);
                    automobili.Add(auto);
                }
                else
                {
                    Console.WriteLine("Ovo nije niti auto niti brod.");
                }

                Console.WriteLine("Želite li unositi još vozila? (d=da, n=ne)");
                //bool unos = Console.ReadLine().ToLower() == "d";
                //if (!unos)
                //{
                //    break;
                //}
                //Isto kao ovo gore, samo kraće napisano

                if (!(Console.ReadLine().ToLower() == "d"))
                    break;
            }

            Console.ReadKey();
        }

        static Brod UcitajBrod()
        {
            Console.WriteLine("Unesite Naziv:");
            string naziv = Console.ReadLine();

            Console.WriteLine("Boja:");
            string boja = Console.ReadLine();

            Console.WriteLine("Snaga:");
            int snaga = int.Parse(Console.ReadLine());

            Console.WriteLine("Istisnina:");
            decimal istisnina = decimal.Parse(Console.ReadLine());

            Brod noviBrod = new Brod(snaga);
            noviBrod.IstisninaPromijenjena += IstisninaBrodaPromijenjenaHandler;

            noviBrod.Boja = boja;
            noviBrod.Istisnina = istisnina;
            noviBrod.Naziv = naziv;

            return noviBrod;
        }

        static Automobil UcitajAutomobil()
        {
            Console.WriteLine("Unesite Naziv:");
            string naziv = Console.ReadLine();

            Console.WriteLine("Boja:");
            string boja = Console.ReadLine();

            Console.WriteLine("Snaga:");
            int snaga = int.Parse(Console.ReadLine());

            Console.WriteLine("Zapremina:");
            decimal zapremina = decimal.Parse(Console.ReadLine());

            Automobil auto = new Automobil(snaga);
            auto.Boja = boja;
            auto.Ccm = zapremina;
            auto.Naziv = naziv;

            return auto;

        }

        static void IstisninaBrodaPromijenjenaHandler(decimal novaIstisnina)
        {
            Console.WriteLine("Istisnina broda je promijenjena u " + novaIstisnina + ".");
        }
    }
}
