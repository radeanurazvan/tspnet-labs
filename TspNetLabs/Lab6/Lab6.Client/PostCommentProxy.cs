﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab6.Wcf.Contracts
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PostDto", Namespace = "http://schemas.datacontract.org/2004/07/Lab6.Wcf.Contracts")]
    public partial class PostDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string DescriptionField;

        private string DomainField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                this.DescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domain {
            get {
                return this.DomainField;
            }
            set {
                this.DomainField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CommentDto", Namespace = "http://schemas.datacontract.org/2004/07/Lab6.Wcf.Contracts")]
    public partial class CommentDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string TextField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                this.TextField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IPostCommentService")]
public interface IPostCommentService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/GetPosts", ReplyAction = "http://tempuri.org/IPostsService/GetPostsResponse")]
    Lab6.Wcf.Contracts.PostDto[] GetPosts();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/GetPosts", ReplyAction = "http://tempuri.org/IPostsService/GetPostsResponse")]
    System.Threading.Tasks.Task<Lab6.Wcf.Contracts.PostDto[]> GetPostsAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/AddPost", ReplyAction = "http://tempuri.org/IPostsService/AddPostResponse")]
    void AddPost(Lab6.Wcf.Contracts.PostDto postDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/AddPost", ReplyAction = "http://tempuri.org/IPostsService/AddPostResponse")]
    System.Threading.Tasks.Task AddPostAsync(Lab6.Wcf.Contracts.PostDto postDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/UpdatePost", ReplyAction = "http://tempuri.org/IPostsService/UpdatePostResponse")]
    void UpdatePost(System.Guid id, Lab6.Wcf.Contracts.PostDto postDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/UpdatePost", ReplyAction = "http://tempuri.org/IPostsService/UpdatePostResponse")]
    System.Threading.Tasks.Task UpdatePostAsync(System.Guid id, Lab6.Wcf.Contracts.PostDto postDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/DeletePost", ReplyAction = "http://tempuri.org/IPostsService/DeletePostResponse")]
    void DeletePost(System.Guid id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPostsService/DeletePost", ReplyAction = "http://tempuri.org/IPostsService/DeletePostResponse")]
    System.Threading.Tasks.Task DeletePostAsync(System.Guid id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/AddPostComment", ReplyAction = "http://tempuri.org/ICommentsService/AddPostCommentResponse")]
    void AddPostComment(System.Guid postId, Lab6.Wcf.Contracts.CommentDto commentDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/AddPostComment", ReplyAction = "http://tempuri.org/ICommentsService/AddPostCommentResponse")]
    System.Threading.Tasks.Task AddPostCommentAsync(System.Guid postId, Lab6.Wcf.Contracts.CommentDto commentDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/AddCommentComment", ReplyAction = "http://tempuri.org/ICommentsService/AddCommentCommentResponse")]
    void AddCommentComment(System.Guid commentId, Lab6.Wcf.Contracts.CommentDto commentDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/AddCommentComment", ReplyAction = "http://tempuri.org/ICommentsService/AddCommentCommentResponse")]
    System.Threading.Tasks.Task AddCommentCommentAsync(System.Guid commentId, Lab6.Wcf.Contracts.CommentDto commentDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/DeleteComment", ReplyAction = "http://tempuri.org/ICommentsService/DeleteCommentResponse")]
    void DeleteComment(System.Guid commentId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommentsService/DeleteComment", ReplyAction = "http://tempuri.org/ICommentsService/DeleteCommentResponse")]
    System.Threading.Tasks.Task DeleteCommentAsync(System.Guid commentId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPostCommentServiceChannel : IPostCommentService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PostCommentServiceClient : System.ServiceModel.ClientBase<IPostCommentService>, IPostCommentService
{

    public PostCommentServiceClient()
    {
    }

    public PostCommentServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public PostCommentServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public PostCommentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public PostCommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public Lab6.Wcf.Contracts.PostDto[] GetPosts()
    {
        return base.Channel.GetPosts();
    }

    public System.Threading.Tasks.Task<Lab6.Wcf.Contracts.PostDto[]> GetPostsAsync()
    {
        return base.Channel.GetPostsAsync();
    }

    public void AddPost(Lab6.Wcf.Contracts.PostDto postDto)
    {
        base.Channel.AddPost(postDto);
    }

    public System.Threading.Tasks.Task AddPostAsync(Lab6.Wcf.Contracts.PostDto postDto)
    {
        return base.Channel.AddPostAsync(postDto);
    }

    public void UpdatePost(System.Guid id, Lab6.Wcf.Contracts.PostDto postDto)
    {
        base.Channel.UpdatePost(id, postDto);
    }

    public System.Threading.Tasks.Task UpdatePostAsync(System.Guid id, Lab6.Wcf.Contracts.PostDto postDto)
    {
        return base.Channel.UpdatePostAsync(id, postDto);
    }

    public void DeletePost(System.Guid id)
    {
        base.Channel.DeletePost(id);
    }

    public System.Threading.Tasks.Task DeletePostAsync(System.Guid id)
    {
        return base.Channel.DeletePostAsync(id);
    }

    public void AddPostComment(System.Guid postId, Lab6.Wcf.Contracts.CommentDto commentDto)
    {
        base.Channel.AddPostComment(postId, commentDto);
    }

    public System.Threading.Tasks.Task AddPostCommentAsync(System.Guid postId, Lab6.Wcf.Contracts.CommentDto commentDto)
    {
        return base.Channel.AddPostCommentAsync(postId, commentDto);
    }

    public void AddCommentComment(System.Guid commentId, Lab6.Wcf.Contracts.CommentDto commentDto)
    {
        base.Channel.AddCommentComment(commentId, commentDto);
    }

    public System.Threading.Tasks.Task AddCommentCommentAsync(System.Guid commentId, Lab6.Wcf.Contracts.CommentDto commentDto)
    {
        return base.Channel.AddCommentCommentAsync(commentId, commentDto);
    }

    public void DeleteComment(System.Guid commentId)
    {
        base.Channel.DeleteComment(commentId);
    }

    public System.Threading.Tasks.Task DeleteCommentAsync(System.Guid commentId)
    {
        return base.Channel.DeleteCommentAsync(commentId);
    }
}
