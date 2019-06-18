using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlazorBlog.Core.Interfaces;

namespace BlazorBlog.Server.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository blogrepository;

        public BlogController(IBlogRepository blogrepository)
        {
            this.blogrepository = blogrepository;
        }

        [HttpGet(BlazorBlog.Core.Constants.ApiEndpoints.GetPosts)]
        public async Task<IActionResult> GetBlogPosts()
        {
            return Ok(await blogrepository.AsyncGetBlogPosts());
        }

        public async Task<IActionResult> GetBlogPost(int id)
        {
            var post = await blogrepository.AsyncGetBlogPost(id);
            if (post== null)
            {
                return NotFound();
            }
            return Ok(post);
        }
    }
}