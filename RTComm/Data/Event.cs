using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class Event
    {
        public int ID { get; set; }
        public Jobs Job { get; set; } // one to many relationship with jobs (one job can have many event, but each event is tied to a singular job)
        public Enum EventList { get; set; }//static list w/ event types
        public string Author { get; set; }//placeholder until reference for users table is made (guess it should be clients or constructionco?
        public DateTime Time { get; set; }
        public ICollection<Comments> Comments { get; set; } //many-to-one relationship with comments (event can have many comments)
    }
}
