using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Zupanija
    {
        public Zupanija()
        {
            Mjestos = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }
        public string NazZupanija { get; set; }

        public virtual ICollection<Mjesto> Mjestos { get; set; }
    }
}
