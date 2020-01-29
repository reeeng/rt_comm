using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class ConstructionCo
    {
        public int ConstructionID { get; set; }
        public string ConstructionName { get; set; }

        public ICollection<Jobs> Jobs { get; set; }
    }
}
