using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Services
{
    public interface IBlogPostService
    {
        Task<MultipleBlogPostsVM> Get(string tag = "");
        Task<BlogPostVM> GetBySlug(string slug);
        Task<BlogPostVM> Insert(BlogPostAddVM blog);
        Task<BlogPostVM> Update(BlogPostUpdateVM blog, string slug);
        Task<bool> Delete(string slug);
    }
}
