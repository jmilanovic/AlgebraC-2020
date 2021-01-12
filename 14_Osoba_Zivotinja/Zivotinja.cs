namespace _14_Osoba_Zivotinja
{
    internal class Zivotinja:IMojInterface
    {
        public string NarodniNaziv { get; internal set; }
        public string LatinskiNaziv { get; internal set; }

        public string PunoIme()
        {
            return this.NarodniNaziv+" "+this.LatinskiNaziv ;
        }
    }
}