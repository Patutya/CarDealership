using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehearse
{
    public class CarFabricCompany
    {
        public string FactoryName { get; set; }
        public string Address { get; set; } 
        public List<BMW> Bmws { get; set; }

        public List<MERC> Mercs { get; set; }
        public List<PORSCHE> Porsches { get; set; }
    }
}
