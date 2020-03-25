using System;

namespace Lab6.Data
{
    public partial class Post : IEntity
    {
        public static Post Create(string domain, string description)
        {
            return new Post
            {
                Id = Guid.NewGuid(),
                Domain = domain,
                Description = description,
                Date = DateTime.Now
            };
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void ChangeDomain(string domain)
        {
            Domain = domain;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }
    }
}