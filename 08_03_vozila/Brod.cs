namespace _08_03_vozila
{
    public class Brod:Vozilo
    {
        //private string Naziv;
        //private string Boja;
        //private int KS;
        private int Istisnina;

        public Brod(string Naziv, string Boja, int KS, int Istisnina):base(Naziv, Boja, KS)
        {
            this.Istisnina = Istisnina;
        }
        public override string ToString()
        {
            return "Ja sam brod "+base.ToString() + " moja istisnina je:" + this.Istisnina;
        }
    }
}