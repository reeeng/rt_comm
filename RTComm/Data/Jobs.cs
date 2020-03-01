using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTComm.Data
{
    public class Jobs
    {
        /*  public Jobs (Client client, ConstructionCo constructionco)
          {
              Client = client;
              ConstructionCo = constructionco;

          }*/


        public int Id { get; set; }
        [Required(ErrorMessage = "Job name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A job cost is required")]
        public decimal Cost { get; set; }
        public string JobAddress { get; set; }

        [Required(ErrorMessage = "An end date is required, even if estimated")]
        public DateTime EndDate { get; set; }

        public ConstructionCo ConstructionCo { get; set; } //foreign key ref to constructionco

        [Required(ErrorMessage = "A start date is required")]
        public DateTime CreatedDate { get; set; }

        // public string ClientName { get; set; }
        public ICollection<Comments> Comments { get; set; } //one too many relationship with comments
        public ICollection<Event> Event { get; set; }

        public Client Client { get; set; } //foreign key ref to clientname

     

    }
}
