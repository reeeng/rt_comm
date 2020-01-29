using System.Collections.Generic;

namespace RTComm.Data
{
    public class ConstructionCo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Jobs> Jobs { get; set; }//many to one relationship with jobs
    }
}
