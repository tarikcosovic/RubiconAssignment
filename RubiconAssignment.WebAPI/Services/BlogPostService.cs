using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.Exceptions;
using RubiconAssignment.WebAPI.ViewModels;
using Slugify;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IMapper mapper;
        private readonly ITagService tagService;

        public BlogPostService(IMapper _mapper, ITagService _tagService)
        {
            mapper = _mapper;
            tagService = _tagService;
        }

        public async Task<MultipleBlogPostsVM> Get(string tag = "")
        {
            using var db = new SQLiteDBContext();

            var result = await db.BlogPosts.Include(k => k.Tags).OrderByDescending(k => k.CreatedAt).ToListAsync();

            //We should make a Query object instead of a string for querying, but since its just the tag I kept it simple
            if (!string.IsNullOrWhiteSpace(tag))
                result = await db.BlogPostTags.Where(x => x.TagId == tag).Select(k => k.BlogPost).ToListAsync();

            var posts = mapper.Map<List<BlogPostVM>>(result);

            ListToArray(result, posts);

            var multiplePosts = new MultipleBlogPostsVM()
            {
                BlogPosts = posts.ToArray(),
                postsCount = posts.Count
            };

            return multiplePosts;
        }
        public async Task<BlogPostVM> GetBySlug(string slug)
        {
            using var db = new SQLiteDBContext();

            var result = await db.BlogPosts.Include(bp => bp.Tags).FirstOrDefaultAsync(k => k.Slug == slug) ?? throw new NotFoundException(slug);

            var post = mapper.Map<BlogPostVM>(result);

            TagListToArray(result, post);

            return post;
        }
        public async Task<BlogPostVM> Insert(BlogPostAddVM request)
        {
            using var db = new SQLiteDBContext();

            var result = mapper.Map<BlogPost>(request);

            SlugHelper helper = new SlugHelper();
            result.Slug = helper.GenerateSlug(result.Title);

            result.CreatedAt = DateTime.UtcNow;
            await db.BlogPosts.AddAsync(result);
            await db.SaveChangesAsync();

            #region MappingTagsToDB
            //If tags are added check if they exist in db, if not save them
            //Add BlogPostTags middle table elements and save them to db
            string[] tagList = null;
            if (request.TagList != null && request.TagList.Length > 0)
            {
                int tagCount = request.TagList.Length;
                tagList = new string[tagCount];

                for (int i = 0; i < tagCount; i++)
                {
                    tagList[i] = request.TagList[i];
                    // If the Tag is not in the database persist it
                    if (await db.Tags.FindAsync(request.TagList[i]) == null)
                        await tagService.Insert(new Tag() { Name = request.TagList[i] });

                    //Add tags to post and save to db 
                    BlogPostTag temp = new BlogPostTag() { TagId = request.TagList[i], BlogPostId = result.Slug };
                    await db.BlogPostTags.AddAsync(temp);
                }
                await db.SaveChangesAsync();
            }
            #endregion 

            var response = mapper.Map<BlogPostVM>(result);
            response.TagList = tagList;

            return response;
        }
        public async Task<BlogPostVM> Update(BlogPostUpdateVM request, string slug)
        {
            using var db = new SQLiteDBContext();

            var blogPost = await db.BlogPosts.Include(x => x.Tags).FirstOrDefaultAsync(bp => bp.Slug == slug) ?? throw new NotFoundException(slug);

            //If Title has been changed
            if(request.Title != blogPost.Title && !string.IsNullOrEmpty(request.Title))
            {
                var tags = new List<BlogPostTag>(blogPost.Tags);
                //Delete all referenced entities
                foreach(var item in blogPost.Tags)
                    db.BlogPostTags.Remove(item);
                await db.SaveChangesAsync();

                blogPost.Tags = null;
                db.BlogPosts.Remove(blogPost);
                await db.SaveChangesAsync();

                //Add the post again with all the tags
                SlugHelper helper = new SlugHelper();
                blogPost.Slug = helper.GenerateSlug(request.Title);

                await db.BlogPosts.AddAsync(blogPost);
                await db.SaveChangesAsync();

                foreach(var tag in tags)
                {
                    var postTag = new BlogPostTag() { TagId = tag.TagId, BlogPostId = blogPost.Slug };
                    await db.BlogPostTags.AddAsync(postTag);
                }
                await db.SaveChangesAsync();

                blogPost.Tags = tags;
            }

            blogPost.UpdatedAt = DateTime.UtcNow;
            mapper.Map(request, blogPost);

            db.BlogPosts.Update(blogPost);
            await db.SaveChangesAsync();

            var response = mapper.Map<BlogPostVM>(blogPost);
            TagListToArray(blogPost, response);

            return response;
        }
        public async Task<bool> Delete(string slug)
        {
            using var db = new SQLiteDBContext();

            var result = await db.BlogPosts.FindAsync(slug) ?? throw new NotFoundException(slug);

            db.BlogPosts.Remove(result);
            await db.SaveChangesAsync();

            return true;
        }

        private void ListToArray(List<BlogPost> from, List<BlogPostVM> to)
        {
            int count = to.Count;

            for (int i = 0; i < count; i++)
            {
                int tagCount = from[i].Tags.Count;

                to[i].TagList = new string[tagCount];

                foreach (var tag in from[i].Tags)
                    to[i].TagList[--tagCount] = tag.TagId;
            }
        }
        private static void TagListToArray(BlogPost from, BlogPostVM to)
        {
            int tagCount = from.Tags?.Count ?? 0;

            to.TagList = new string[tagCount];

            if(from.Tags != null)
                foreach (var tag in from.Tags)
                    to.TagList[--tagCount] = tag.TagId;
        }
        
    }
}
