using System;

namespace _09_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // inicijalizacija, pozdrav, kapitalizacija
            // o1.ime, o1.prezime

            Osoba o1 = new Osoba(Ime:"dARkO",Prezime:"fRAniC");
            Console.WriteLine(o1);




        }
    }
}
