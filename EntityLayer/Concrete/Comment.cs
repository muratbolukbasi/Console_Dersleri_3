using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
        public string CommentContent { get; set; }
        public bool CommentStatus { get; set; }
        
    }
}
