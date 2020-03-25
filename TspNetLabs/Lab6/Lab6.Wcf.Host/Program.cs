using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Lab6.Wcf.Contracts;

namespace Lab6.Wcf.Host
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost(typeof(PostCommentService),
                new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"A (address): {se.Address} \nB (binding): {se.Binding.Name} \nC(Contract): {se.Contract.Name}\n");

            }

            host.Open();

            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadLine();
            
            host.Close();
        }
    }
}
