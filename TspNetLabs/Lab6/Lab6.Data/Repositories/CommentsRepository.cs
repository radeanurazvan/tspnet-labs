using System.Data.Entity;
using System.Linq;

namespace Lab6.Data.Repositories
{
    public sealed class CommentsRepository : Repository<Comment>
    {
        public CommentsRepository() : base(new PostCommentModelContainer())
        {
        }

        protected override IQueryable<Comment> DecorateEntities(IQueryable<Comment> entities)
        {
            return entities.Include(c => c.Post);
        }
    }
}