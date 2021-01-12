using System;

namespace _08_03_Nasljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nasljedjivanje");

            Osoba o1 = new Osoba("Pajo", "Patak");
            Ucenik u1 = new Ucenik("Miki", "Mouse");
            Ucenik u2 = new Ucenik("Kiki", "Riki", Matematika: 3);
            Ucenik u3 = new Ucenik()
            {
                Ime = "Lumen",
                Prezime = "Menlu",
                Matematika = 5
            };

            Console.WriteLine("Dobar dan, ja se prezivam " + u1.Prezime);

            Console.WriteLine("Moja ocjena im matematike: " + u1.Matematika);
            u1.Matematika = 4;
            Console.WriteLine("Moja ocjena im matematike: " + u1.Matematika);

            Console.WriteLine("Dobar dan, ja se prezivam " + u2.Prezime);
            Console.WriteLine("Moja ocjena im matematike: " + u2.Matematika);

            Console.WriteLine("Dobar dan, ja se prezivam " + u3.Prezime);
            Console.WriteLine("Moja ocjena im matematike: " + u3.Matematika);

            Console.WriteLine(u2);
            Console.WriteLine(o1);


        }
    }
}
