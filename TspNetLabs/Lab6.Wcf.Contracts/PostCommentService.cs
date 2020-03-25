using System;
using Lab6.Data;
using Lab6.Data.Repositories;

namespace Lab6.Wcf.Contracts
{
    public sealed class PostCommentService : IPostCommentService
    {
        private readonly IRepository<Post> postRepository;
        private readonly IRepository<Comment> commentRepository;

        public PostCommentService()
        {
            postRepository = new PostsRepository();
            commentRepository = new CommentsRepository();
        }

        public void AddPostComment(Guid postId, CommentDto commentDto)
        {
            var post = postRepository.GetById(postId);
            post?.AddComment(Comment.Create(commentDto.Text));

            postRepository.SaveChanges();
        }

        public void AddCommentComment(Guid commentId, CommentDto commentDto)
        {
            var comment = commentRepository.GetById(commentId);
            comment?.AddComment(Comment.Create(commentDto.Text));

            commentRepository.SaveChanges();
        }

        public void DeleteComment(Guid commentId)
        {
            commentRepository.Delete(commentId);
            commentRepository.SaveChanges();
        }

        public void AddPost(PostDto postDto)
        {
            var post = Post.Create(postDto.Domain, postDto.Description);
            postRepository.Add(post);
            postRepository.SaveChanges();
        }

        public void UpdatePost(Guid id, PostDto postDto)
        {
            var post = postRepository.GetById(id);
            post?.ChangeDescription(postDto.Description);
            post?.ChangeDomain(postDto.Domain);
            postRepository.SaveChanges();
        }

        public void DeletePost(Guid id)
        {
            postRepository.Delete(id);
            postRepository.SaveChanges();
        }
    }
}