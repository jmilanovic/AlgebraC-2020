using System;

namespace _08_03_employee_liste
{
    internal class Employee
    {
        private static int ukupanBrojZaposlenika;

        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public int Salary { get; internal set; }
        public static int UkupanBrojZaposlenika { get => ukupanBrojZaposlenika; set => ukupanBrojZaposlenika = value; }

        public Employee()
        {
            UkupanBrojZaposlenika++;
        }


        /// <summary>
        /// Ova metoda uduplava placu
        /// </summary>
        internal void PlacaPutaDva()
        {
            int koeficijent = 2;
            this.Salary *= koeficijent;
        }
        /// <summary>
        /// Ova metoda daje lijepo formatirani ispis zaposlenika
        /// </summary>
        public override string ToString()
        {
            // return base.ToString();
            return "Moje ime je "+Name+" i moja placa je "+Salary+"kn";
        }
    }
}