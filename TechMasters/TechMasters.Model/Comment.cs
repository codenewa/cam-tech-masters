using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechMasters.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string CommentText { get; set; }
    }
}
