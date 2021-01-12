using System;

namespace Kolac_kam

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DOBRODOŠLI U SLASTIČARNU!");
            Console.WriteLine("");
            Console.WriteLine("Kolač dana je 'Čokoladna ekstaza'.");

            #region dodavanjekolaca

            // Primjer kolača - K1
            Kolac K1 = new Kolac("Cokoladna ekstaza");
            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Secer", 100);
            K1.DodajSastojak("Cokolada", 300);
            K1.DodajSastojak("Jaje", 50);

            #endregion

            Rerna.Ispeci(ref K1);
            Console.WriteLine("");


            Console.WriteLine(K1);
            Console.WriteLine("");

            Console.WriteLine("Dosad ste ispekli " + Rerna.BrojIspecenihKolaca.ToString() + " kolač! Ispecite i kolač po vlastitom izboru!");

            // Korisnikov kolač - K2
            Console.WriteLine("");
            Kolac K2 = new Kolac();
            Console.Write("Ime vašeg kolača: ");
            K2.ImeKolaca = Console.ReadLine();
            Console.Write("Pritisnite ENTER pa unesite željene sastojke ili upišite 'peci' za nastavak.");
            Console.WriteLine("");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "peci")
                {
                    break;
                }
                Console.Write("Ime sastojka: ");
                string imeSastojka = Console.ReadLine();
                Console.Write("Gramaža: ");
                int gramaza = int.Parse(Console.ReadLine());
                K2.DodajSastojak(imeSastojka, gramaza);
            }
            Rerna.Ispeci(ref K2);
            Console.WriteLine("");

            Console.WriteLine(K2);
            Console.WriteLine("");

            K1.DodajSastojak("Limun", 100);

            // Završetak
            Console.WriteLine("U vašoj kuharici ukupno je " + Kolac.BrojRecepata.ToString() + " recepata!");
            Console.WriteLine("Dosad ste ispekli " + Rerna.BrojIspecenihKolaca.ToString() + " kolača! Uživajte!");
        }
    }
}