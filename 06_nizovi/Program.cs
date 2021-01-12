using System;

namespace _06_nizovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nizovi");

            int[] brojevi =new int[3];  // deklarirali jednodimenzionalno polje od 3 elementa
            brojevi[0] = 19;   // pocetni index je 0   < -----  PAMTI
            brojevi[1] = 29;
            brojevi[2] = 39;
            //brojevi[3] = 99;   // array inx out of bounds exeption  // ovo se ne smije


            Console.WriteLine("Drugi element ima vrijednost :"+brojevi[2]);

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine("{0} element ima vrijednost: {1}",i, brojevi[i]);
            }
            foreach (var item in brojevi)
            {
                Console.WriteLine(item.GetType()+" vrijednost:"+item );
            }

            Console.WriteLine("Unesi 5 brojeva");

            int[] numbars = new int[5];

            for (int i = 0; i < numbars.Length; i++)
            {
                Console.Write("Unesi {0}. broj: ", i+1);
                numbars[i]=int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Unijeli ste sljedece brojeve:");
            foreach (var item in numbars)
            {
                Console.Write("{0} ", item);
            }


            // Ispis unatrag

            for (int i = numbars.Length-1; i>=0 ; i--)  //od 4 do 0
            {
                Console.WriteLine("{0}. broj je: {1}", i + 1, numbars[i]);
            }

        }
    }
}
