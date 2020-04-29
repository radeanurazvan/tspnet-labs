using System;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Lab10.Service.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Lab10.Service
{
    public class PostCommentService : PostComment.PostCommentBase
    {

        public override async Task<Empty> AddPost(AddPostRequest request, ServerCallContext context)
        {
            await RunOnDb(c =>
            {
                c.Posts.Add(new Post
                {
                    Title = request.Title,
                    Content = request.Content
                });

                return c.SaveChangesAsync();
            });

            return new Empty();
        }

        public override async Task<PostsResponse> GetPosts(Empty request, ServerCallContext context)
        {
            var posts = await RunOnDb(c => c.Posts.ToListAsync());
            var response = new PostsResponse();
            response.Posts.AddRange(posts.Select(p => new PostDto { Title = p.Title, Content = p.Content }));

            return response;
        }

        private async Task RunOnDb(Func<PostCommentContext, Task> func)
        {
            using (var context = new PostCommentContext())
            {
                await func(context);
            }
        }

        private async Task<T> RunOnDb<T>(Func<PostCommentContext, Task<T>> func)
        {
            using (var context = new PostCommentContext())
            {
                return await func(context);
            }
        }
    }
}
