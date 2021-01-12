using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Vozila_8_3_1
{
    class Automobili:CollectionBase
    {
        public List<Automobil> auti = new List<Automobil>();
        public void Add(Automobil auti_svi)
        {
          auti.Add(auti_svi);
        }
        
        public void Remove()
        { 
        
        }

        public void Indexer()
        { 
        
        }

    
    }
}
