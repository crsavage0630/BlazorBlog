using BlazorBlog.Core.Entities;
using BlazorBlog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Infrastructure.Repositories
{
    public class InMemoryBlogRepository : IBlogRepository
    {
        private List<BlogPost> _blogPosts;
        public InMemoryBlogRepository()
        {
            _blogPosts = new List<BlogPost>();

            _blogPosts.Add(new BlogPost() { Id = 1, Author = "Me", Created = DateTime.Now.AddHours(-12), Summary = "Blog Summary", Text = "This is a big blog about stuff", Title = "Blog Title" });
            _blogPosts.Add(new BlogPost() { Id = 2, Author = "Me", Created = DateTime.Now.AddHours(-12), Summary = "Another Blog Summary", Text = "This is a big blog about stuff", Title = "Another Title" });

        }
        public IList<BlogPost> GetBlogPosts()
        {
            return _blogPosts;
        }


        public Task<IList<BlogPost>> AsyncGetBlogPosts()
        {
            return Task.FromResult(GetBlogPosts());
        }

        public BlogPost GetBlogPost(int id)
        {
            return _blogPosts.FirstOrDefault(x => x.Id == id);
           
        }
        public Task<BlogPost> AsyncGetBlogPost(int id)
        {
            return Task.FromResult(GetBlogPost(id));
        }
    }
}
