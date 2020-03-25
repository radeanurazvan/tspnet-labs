using System;
using System.ServiceModel;

namespace Lab6.Wcf.Contracts
{
    [ServiceContract]
    public interface ICommentsService
    {
        [OperationContract]
        void AddPostComment(Guid postId, CommentDto commentDto);

        [OperationContract]
        void AddCommentComment(Guid commentId, CommentDto commentDto);

        [OperationContract]
        void DeleteComment(Guid commentId);
    }
}