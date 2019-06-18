using BlazorBlog.Core.Interfaces;
using BlazorBlog.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBlog.Infrastructure
{
    public class RegisterServices
    {
        public static void RegisterDependencyInjection(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBlogRepository, InMemoryBlogRepository>();
        }
    }
}
