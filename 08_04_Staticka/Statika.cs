using System;

namespace _08_04_Staticka
{
    internal class Statika
    {
        private Statika() { }
        internal static string Zbroj(int prvi_broj, int drugi_broj)
        {
            return (prvi_broj + drugi_broj).ToString();
        }

        internal static string Kub(int broj)
        {
            //  return (broj*broj *broj).ToString();
            return Math.Pow(broj, 3).ToString();
        }

        internal static string Udaljenost2D(Tocka A, Tocka B)
        {

            return Math.Sqrt(Math.Pow(A.X-B.X,2)+ Math.Pow(A.Y-B.Y,2)).ToString();
        }

        internal class Tocka
        {
            private int x;
            private int y;

            public override string ToString()
            {
                return "Koordinata x:" + X + " y:" + Y;
            }
            public Tocka(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            internal void IdiGore(int v)
            {
                y += v;
            }
            internal void IdiDolje(int v)
            {
                y -= v;
            }
            internal void IdiDesno(int v)
            {
                x += v;
            }
            internal void IdiLijevo(int v)
            {
                x -= v;
            }

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }

        internal class Duljina
        {
            private Tocka A;
            private Tocka B;

            public Duljina(Tocka A, Tocka B)
            {
                this.A = A;
                this.B = B;
            }
            public override string ToString()
            {
                return "Ja sam duljina ogranicena tockama " 
                    + A.ToString() + " " 
                    + B.ToString() 
                    + " Duljina mi je " 
                    + Udaljenost2D(A, B); 
            }
        }
    }
}