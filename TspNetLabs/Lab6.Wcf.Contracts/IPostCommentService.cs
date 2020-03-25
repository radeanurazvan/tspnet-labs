using System.ServiceModel;

namespace Lab6.Wcf.Contracts
{
    [ServiceContract]
    public interface IPostCommentService : IPostsService, ICommentsService
    {
        
    }
}