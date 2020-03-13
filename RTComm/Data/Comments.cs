using System;
using System.ComponentModel.DataAnnotations;

namespace RTComm.Data
{
    public class Comments
    {
        public int ID { get; set; }

        public Jobs Job { get; set; }
        public string Comment { get; set; }

        [Required]
        public string Author { get; set; }//placeholder until reference for users table is made (guess it should be clients or constructionco?
        public DateTime Time { get; set; }

       // public Event Event { get; set; }



    }
}
