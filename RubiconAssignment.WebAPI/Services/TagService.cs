using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Services
{
    public class TagService : ITagService
    {
        private readonly IMapper mapper;
        public TagService(IMapper _mapper)
        {
            mapper = _mapper;
        }

        public async Task<TagVM> Get()
        {
            using var db = new SQLiteDBContext();

            TagVM tags = new TagVM() { Tags = await db.Tags.Select(k => k.Name).ToListAsync()};

            return tags;
        }
        public async Task<Tag> Insert(Tag tag)
        {
            using var db = new SQLiteDBContext();

            if(!string.IsNullOrEmpty(tag.Name))
            {
                await db.Tags.AddAsync(tag);
                await db.SaveChangesAsync();
            }

            return tag;
        }
    }
}
