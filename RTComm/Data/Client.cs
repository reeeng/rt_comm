using System.Collections.Generic;

namespace RTComm.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Jobs> Jobs { get; set; } //1 to many relationship with jobs. a client can have many jobs active w/ REE


    }
}
