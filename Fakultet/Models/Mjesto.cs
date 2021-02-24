using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Mjesto
    {
        public Mjesto()
        {
            Nastavniks = new HashSet<Nastavnik>();
            StudPbrRodNavigations = new HashSet<Stud>();
            StudPbrStanNavigations = new HashSet<Stud>();
        }

        public int Pbr { get; set; }
        public string NazMjesto { get; set; }
        public short? SifZupanija { get; set; }

        public virtual Zupanija SifZupanijaNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavniks { get; set; }
        public virtual ICollection<Stud> StudPbrRodNavigations { get; set; }
        public virtual ICollection<Stud> StudPbrStanNavigations { get; set; }
    }
}
