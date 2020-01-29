using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class Jobs
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobCategory { get; set; }
        public decimal Cost { get; set; }
        public ConstructionCo ConstructionName { get; set; } //does this work as a foreign key reference?
        public DateTime CreatedDate { get; set; }

       // public string ClientName { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public Client ClientName { get; set; } //does this work as a foreign key reference?

    }
}
