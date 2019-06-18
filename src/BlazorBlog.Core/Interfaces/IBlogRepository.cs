using BlazorBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Core.Interfaces
{
    public interface IBlogRepository
    {
        IList<BlogPost> GetBlogPosts();
        Task<IList<BlogPost>> AsyncGetBlogPosts();
        BlogPost GetBlogPost(int id);
        Task<BlogPost> AsyncGetBlogPost(int id);
    }
}
