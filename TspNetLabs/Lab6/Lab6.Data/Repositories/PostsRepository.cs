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
    }
}