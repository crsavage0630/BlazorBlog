using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBlog.Core.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string Text { get; set; }
        public string Summary { get; set; }
    }
}
