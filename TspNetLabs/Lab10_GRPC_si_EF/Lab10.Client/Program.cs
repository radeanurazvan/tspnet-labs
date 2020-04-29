using System;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Lab10.Service;

namespace Lab10.Client
{
    public static class Program
    {
        private static PostComment.PostCommentClient client;

        public static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            client = new PostComment.PostCommentClient(channel);

            while (true)
            {
                await DisplayPosts();
                await AskForNewPost();
            }
        }

        private static async Task AskForNewPost()
        {
            Console.WriteLine("Enter a post title:");
            var title = Console.ReadLine();

            Console.WriteLine("Enter the post content:");
            var content = Console.ReadLine();

            await client.AddPostAsync(new AddPostRequest
            {
                Title = title,
                Content = content
            });
        }

        private static async Task DisplayPosts()
        {
            var posts = (await client.GetPostsAsync(new Empty())).Posts.ToList();

            Console.WriteLine($"Found {posts.Count} posts:");
            foreach (var post in posts)
            {
                Console.WriteLine("==============================");
                Console.WriteLine($"{post.Title}: {post.Content}");
                Console.WriteLine("==============================");
            }
        }
    }
}
