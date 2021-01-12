using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inter
{
    internal class Tocka : Point, IPoint
    {
        public Tocka(int x, int y):base(x+1,y+1){}

    }
}
