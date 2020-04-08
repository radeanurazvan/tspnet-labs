using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Lab8.GprcGreeter;

namespace Lab8.GprcGreeterClient
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
