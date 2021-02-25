using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Rezervacija
    {
        public string OznDvorana { get; set; }
        public string OznVrstaDan { get; set; }
        public short Sat { get; set; }
        public int SifPred { get; set; }

        public virtual Dvorana OznDvoranaNavigation { get; set; }
        public virtual Pred SifPredNavigation { get; set; }

        // Many 2 Many
        /*
        public Rezervacija() {
            Dvoranas = new HashSet<Dvorana>();
            Preds = new HashSet<Pred>();
        }
        public virtual ICollection<Dvorana> Dvoranas { get; set; }
        public virtual ICollection<Pred> Preds { get; set; }

        */
    }
}
