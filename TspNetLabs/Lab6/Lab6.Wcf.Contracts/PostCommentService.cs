﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            post?.AddComment(Comment.Create(post, commentDto.Text));

            postRepository.SaveChanges();
        }

        public void DeleteComment(Guid commentId)
        {
            commentRepository.Delete(commentId);
            commentRepository.SaveChanges();
        }

        public IEnumerable<PostDto> GetPosts()
        {
            return postRepository.GetAll().Select(p => new PostDto
            {
                Id = p.Id,
                Description = p.Description,
                Domain = p.Domain,
                Comments = p.Comments.Select(c => new CommentDto
                {
                    Text = c.Text
                })
            });
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