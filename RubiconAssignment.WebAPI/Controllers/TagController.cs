using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.Services;
using RubiconAssignment.WebAPI.ViewModels;

namespace RubiconAssignment.WebAPI.Controllers
{
    [Route("api/tags")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService tagService = null;
        public TagController(ITagService _tagService)
        {
            tagService = _tagService;
        }

        [HttpGet]
        public async Task<ActionResult<TagVM>> GetAsync()
        {
            var result = await tagService.Get();

            return Ok(result);
        }
    }
}
