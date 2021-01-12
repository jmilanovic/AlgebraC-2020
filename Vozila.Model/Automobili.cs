using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    class Automobili: System.Collections.CollectionBase
    {
        public void Add(Automobil noviAuto)
        {
            base.InnerList.Add(noviAuto);
        }

    }
}
