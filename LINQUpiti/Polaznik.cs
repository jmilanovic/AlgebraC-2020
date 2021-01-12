using System;

namespace LINQUpiti
{
    internal class Polaznik
    {
        public string Ime { get; internal set; }
        public string Prezime { get; internal set; }
        public DateTime DatumRodenja { get; internal set; }
        public Seminar UpisaniSeminar { get; internal set; }
    }
}