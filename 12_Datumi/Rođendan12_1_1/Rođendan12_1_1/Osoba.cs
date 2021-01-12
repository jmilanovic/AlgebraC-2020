/*
 Klasa Osoba
 Svojstva
o Ime (string)
o Prezime (string)
o DatumRodjenja (DateTime)
o Starost (int) – ReadOnly svojstvo
o Spol (spol) – tip spol je Enumeracija
 Metode
o Konstruktor koji traži parametre ime i prezime
 Događaji
o Rođendan – podiže se na promjenu svojstva DatumRodjenja
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Rođendan12_1_1
{
    public enum Spol
    {
        Muški,
        Ženski
    }
    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }

            set { datumRodjenja = value; }
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
            
        }

     

        public int Starost { 
            get  {
                DateTime d2 = DateTime.Now;
                TimeSpan Starost1 = d2 - datumRodjenja;
                return Convert.ToInt32(Starost1.Days / 365);
            }        
        }
        private Spol spol;
       
        public Spol Spol { get { return (Spol)spol;  } set { spol = value; } }

      
        public override string ToString()
        {
            return Ime+" "+Prezime+" koji je rođen dana"+" "+datumRodjenja.ToLongDateString()+" ima "+Starost+" godina.";
        }
    }
}
