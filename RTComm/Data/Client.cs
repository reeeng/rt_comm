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

        [Required]
        public bool IsActive { get; set; } //boolean to toggle active or inactive job status 

        public ICollection<Jobs> Jobs { get; set; } //1 to many relationship with jobs. a client can have many jobs active w/ REE


    }
}
