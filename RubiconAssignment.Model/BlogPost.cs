using System;
using System.Collections.Generic;
using System.Text;

namespace RubiconAssignment.Model
{
    public class BlogPost
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public ICollection<BlogPostTag> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
