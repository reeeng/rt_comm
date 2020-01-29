using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }

        public string CommentAuthor { get; set; }
        public DateTime CommentTime { get; set; }



    }
}
