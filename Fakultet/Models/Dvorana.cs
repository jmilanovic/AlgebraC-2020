using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Dvorana
    {
        public string OznDvorana { get; set; }
        public int? Kapacitet { get; set; }
        
        
        // Many 2 Many
       // public virtual Rezervacija OznDvoranaNavigation { get; set; }
    }
}
