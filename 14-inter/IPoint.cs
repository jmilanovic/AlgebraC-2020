using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inter
{
    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }

        void PrintPoint();

        BojaTocke setBoja(string boja);

        void PomakniMeZaX(int v);
        void PomakniMeZaY(int v);

    }
}
