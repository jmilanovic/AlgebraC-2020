using System;
using System.Collections.Generic;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class VrstaRobe
    {
        public VrstaRobe()
        {
            Poklons = new HashSet<Poklon>();
            Trgovinas = new HashSet<Trgovina>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Poklon> Poklons { get; set; }
        public virtual ICollection<Trgovina> Trgovinas { get; set; }
    }
}
