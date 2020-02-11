using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTComm.Data
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "Client name is required")]
        public string Name { get; set; }
        public ICollection<Jobs> Jobs { get; set; } //1 to many relationship with jobs. a client can have many jobs active w/ REE


    }
}
