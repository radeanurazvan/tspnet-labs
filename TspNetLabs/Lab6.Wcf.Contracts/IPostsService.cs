using System;
using System.ServiceModel;

namespace Lab6.Wcf.Contracts
{
    [ServiceContract]
    public interface IPostsService
    {
        [OperationContract]
        void AddPost(PostDto postDto);

        [OperationContract]
        void UpdatePost(Guid id, PostDto postDto);

        [OperationContract]
        void DeletePost(Guid id);
    }
}