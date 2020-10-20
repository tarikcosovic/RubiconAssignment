using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.Exceptions;
using RubiconAssignment.WebAPI.Services;
using RubiconAssignment.WebAPI.ViewModels;

namespace RubiconAssignment.WebAPI.Controllers
{
    [Route("api/posts/")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet]
        public async Task<ActionResult<MultipleBlogPostsVM>> Get([FromQuery]string tag = "")
        {
            var list = await _blogPostService.Get(tag);

            return Ok(list);
        }

        [HttpGet("{slug}")]
        public async Task<ActionResult<BlogPostVM>> GetBySlug(string slug)
        {
            var result = await _blogPostService.GetBySlug(slug);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<BlogPostVM>> Insert(BlogPostAddVM request)
        {
            var result = await _blogPostService.Insert(request);

            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpPut("{slug}")]
        public async Task<ActionResult<BlogPostVM>> Update(BlogPostUpdateVM request, string slug)
        {
            var result = await _blogPostService.Update(request, slug);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete("{slug}")]
        public async Task<ActionResult> DeleteA(string slug)
        {
            await _blogPostService.Delete(slug);

            return NoContent();
        }

    }
}
