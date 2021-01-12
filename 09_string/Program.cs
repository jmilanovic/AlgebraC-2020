using System;

namespace _09_string
{
    class Program
    {
 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Mi name iz Ante");  //Hello World!

            string txt = "Hello World! Mi name iz Ante";
           // string[] rijeci = txt.Split();  // ako dijelimo po razmaku, ne moramo navoditi argument
            string[] rijeci = txt.Split(""); // isto kao gore

            // Ispis mala slova
            Console.WriteLine(txt.ToLower());  // hello world!
          

            // Ispis velika slova
            Console.WriteLine(txt.ToUpper()); //  HELLO WORLD!

            // Ispis velika slova
            Console.WriteLine(txt.Substring(2,5)); // llo W

            // Ispis velika slova
            Console.WriteLine(Reverse(txt.Substring(2, 5))); // W oll

            // Ispis velika slova
            Console.WriteLine(Reverse(txt.Substring(2, 5)).Replace(" ", "")); // Woll

            // ispis recenice po redovima, odvojeno prazninom
            foreach (var r in rijeci)
            {
                Console.WriteLine(r);
            }

            // duljina recenice je+_
            Console.WriteLine("duljina recenice je: "+txt.Length); //  HELLO WORLD!

            // vraca ! 
            Console.WriteLine("12. slovo je " + txt[11]); //  
            txt.

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
