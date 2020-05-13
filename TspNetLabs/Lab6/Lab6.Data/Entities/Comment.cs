using System;

namespace Lab6.Data
{
    public partial class Comment : IEntity
    {
        public static Comment Create(Post post, string text)
        {
            return new Comment
            {
                Id = Guid.NewGuid(),
                PostId = post.Id,
                Post = post,
                Text = text
            };
        }
    }
}