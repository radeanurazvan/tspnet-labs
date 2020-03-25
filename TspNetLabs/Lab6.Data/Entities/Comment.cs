using System;

namespace Lab6.Data
{
    public partial class Comment : IEntity
    {
        public static Comment Create(string text)
        {
            return new Comment
            {
                Id = Guid.NewGuid(),
                Text = text
            };
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }
}