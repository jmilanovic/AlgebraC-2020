using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Orgjed
    {
        public Orgjed()
        {
            InverseSifNadorgjedNavigation = new HashSet<Orgjed>();
            Nastavniks = new HashSet<Nastavnik>();
            Preds = new HashSet<Pred>();
        }

        public int SifOrgjed { get; set; }
        public string NazOrgjed { get; set; }
        public int? SifNadorgjed { get; set; }

        public virtual Orgjed SifNadorgjedNavigation { get; set; }
        public virtual ICollection<Orgjed> InverseSifNadorgjedNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavniks { get; set; }
        public virtual ICollection<Pred> Preds { get; set; }
    }
}
