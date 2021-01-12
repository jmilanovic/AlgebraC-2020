namespace _14_inter
{
    internal class Korisnik : IKorisnik
    {
        private string username;

        public void LogirajMe()
        {
            throw new System.NotImplementedException();
        }

        public void OdLogirajMe()
        {
            throw new System.NotImplementedException();
        }

        public void PotvrdiMail(string mail)
        {
            throw new System.NotImplementedException();
        }

        public void RegistrirajMe(string korisnicko_ime)
        {
            this.username = korisnicko_ime;
        }
        public override string ToString()
        {
            return this.username;
        }

        public void RegistrirajMeblalalala(string korisnicko_ime)
        {
            this.username = korisnicko_ime;
        }
    }
}