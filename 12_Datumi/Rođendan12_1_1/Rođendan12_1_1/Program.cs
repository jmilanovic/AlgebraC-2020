/*
 Klasa Osoba
 Svojstva
o Ime (string)
o Prezime (string)
o DatumRodjenja (DateTime)
o Starost (int) – ReadOnly svojstvo
o Spol (spol) – tip spol je Enumeracija
 Metode
o Konstruktor koji traži parametre ime i prezime
 Događaji
o Rođendan – podiže se na promjenu svojstva DatumRodjenja
 */
using System;

namespace Rođendan12_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime");
            string prezime = Console.ReadLine();
            Console.WriteLine("Unesite datum rođenja:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Unesite spol (1=Muški, 2=ženski)");
            int spol = int.Parse(Console.ReadLine());

            Osoba unos = new Osoba(ime, prezime);
            unos.DatumRodjenja = d1;

            if (spol == 1)
                unos.Spol = Spol.Muški;
            else if (spol == 0)
                unos.Spol = Spol.Ženski;
            Console.WriteLine("\n" + unos);

            
            




        }
    }
}
