using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inter
{
    interface IKorisnik
    {
        void RegistrirajMe(string korisnicko_ime);
        void PotvrdiMail(string mail);
        void LogirajMe();
        void OdLogirajMe();
        string ToString();
    }
}
