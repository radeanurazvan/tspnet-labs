using System;
using System.Data.Entity;
using System.Linq;

namespace Lab6.Data.Repositories
{
    public sealed class PostsRepository : Repository<Post>
    {
        public PostsRepository() : base(new PostCommentModelContainer())
        {
        }

        protected override IQueryable<Post> DecorateEntities(IQueryable<Post> entities)
        {
            return entities.Include(e => e.Comments);
        }

        public override void Delete(Guid id)
        {
            var post = GetById(id);
            var commentsToDelete = post.Comments.ToList();
            foreach (var comment in commentsToDelete)
            {
                context.Comments.Remove(comment);
            }

            context.Posts.Remove(post);
        }
    }
}