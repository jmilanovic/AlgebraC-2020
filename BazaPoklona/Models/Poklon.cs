using System;
using System.Collections.Generic;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class Poklon
    {
        public int IdPoklon { get; set; }
        public string Naziv { get; set; }
        public int VrstaRobe { get; set; }
        public bool Kupljen { get; set; }

        public float Cijena { get; set; }
        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}
