using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime CreateDate { get; set; }
        
    }
}