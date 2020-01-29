using System;
using System.ComponentModel.DataAnnotations;

namespace RTComm.Data
{
    public class Comments
    {
        public int ID { get; set; }
        public string Comment { get; set; }

        [Required]
        public string Author { get; set; }//placeholder until reference for users table is made
        public DateTime Time { get; set; }



    }
}
