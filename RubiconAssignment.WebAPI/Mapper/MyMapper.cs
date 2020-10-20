using AutoMapper;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RubiconAssignment.WebAPI.Mapper
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<BlogPost, BlogPostVM>().
                ForMember(x => x.TagList, opt => opt.MapFrom(k => k.Tags.Select(tg => tg.TagId).ToArray())).
                ReverseMap();

            CreateMap<BlogPostUpdateVM, BlogPost>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<BlogPost, BlogPostUpdateVM>();

            CreateMap<BlogPost, BlogPostAddVM>().
                ForMember(x => x.TagList, opt => opt.MapFrom(k => k.Tags.Select(tg => tg.TagId).ToArray())).
                ReverseMap().
                ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
