using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fakultet.Models
{
    public class StudMjestoRod
    {
        public int MbrStud { get; set; }
        public Stud Stud { get; set; }
        public int Pbr { get; set; }
        public Mjesto Mjesto { get; set; }
    }
}
