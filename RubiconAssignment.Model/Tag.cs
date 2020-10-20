using System;
using System.Collections.Generic;
using System.Text;

namespace RubiconAssignment.Model
{
    public class Tag
    {
        public string Name { get; set; }
        public ICollection<BlogPostTag> BlogPosts { get; set; }
    }
}
