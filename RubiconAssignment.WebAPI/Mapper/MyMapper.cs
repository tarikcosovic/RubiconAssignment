using AutoMapper;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.ViewModels;
using System.Collections.Generic;

namespace RubiconAssignment.WebAPI.Mapper
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<BlogPost, BlogPostVM>();
            CreateMap<BlogPostVM, BlogPost>();

            CreateMap<BlogPostUpdateVM, BlogPost>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<BlogPost, BlogPostUpdateVM>();

            CreateMap<BlogPost, BlogPostAddVM>();
            CreateMap<BlogPostAddVM, BlogPost>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
