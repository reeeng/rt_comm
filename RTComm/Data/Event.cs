using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public enum EventType
    {
        NewProject = 0,
        DesignChange = 1,
        TimeEstimateChange = 2,
        CostEstimateChange = 3
    }

    public class Event
    {
        public int ID { get; set; }
        public Jobs Job { get; set; } // one to many relationship with jobs (one job can have many event, but each event is tied to a singular job)
        public EventType Type { get; set; } // Type of event
        public string Author { get; set; }//placeholder until reference for users table is made (guess it should be clients or constructionco?
        public DateTime Time { get; set; }
        public ICollection<Comments> Comments { get; set; } //many-to-one relationship with comments (event can have many comments)
    }
}
