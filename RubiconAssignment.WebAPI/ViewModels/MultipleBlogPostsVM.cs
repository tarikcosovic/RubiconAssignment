using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.ViewModels
{
    public class MultipleBlogPostsVM
    {
        public BlogPostVM[] BlogPosts { get; set; }
        public int postsCount { get; set; }
    }
}
