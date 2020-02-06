using System;
using System.Collections.Generic;

namespace RTComm.Data
{
    public class Jobs
    {
        public Jobs (Client client, ConstructionCo constructionco)
        {
            Client = client;
            ConstructionCo = constructionco;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public ConstructionCo ConstructionCo { get; set; } //foreign key ref to constructionco
        public DateTime CreatedDate { get; set; }

        // public string ClientName { get; set; }
        public ICollection<Comments> Comments { get; set; } //one too many relationship with comments
        public Client Client { get; set; } //foreign key ref to clientname

    }
}
