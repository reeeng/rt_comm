using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RTComm.Data

{
    public class ConstructionCo
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Construction Company name is required")]
        public string Name { get; set; }
        public ICollection<Jobs> Jobs { get; set; }//many to one relationship with jobs
    }
}
