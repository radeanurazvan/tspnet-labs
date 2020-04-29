using System;

namespace Lab10.Service.EntityFramework
{
    public class Post
    {
        public Post()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}