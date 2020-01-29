using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public ICollection<Jobs> Jobs { get; set; } //1 to many relationship with jobs. a client can have many jobs active w/ REE


    }
}
