using System;
using Lab4.Db;
using Lab4.Entities;

namespace Lab4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var context = new DatabaseContext();

            Console.WriteLine("Creating products...");
            context.CreateProducts();

            Console.WriteLine("Creating clients....");
            context.CreateClients();

            Console.WriteLine("Creating orders...");
            context.CreateOrders();

            context.SaveChanges();
        }

        private static void CreateProducts(this DatabaseContext context)
        {
            context.Products.Add(DefaultData.Products.Shirt);
            context.Products.Add(DefaultData.Products.Water);
        }

        private static void CreateClients(this DatabaseContext context)
        {
            context.Clients.Add(DefaultData.Clients.Bob);
            context.Clients.Add(DefaultData.Clients.Alice);
        }

        private static void CreateOrders(this DatabaseContext context)
        {
            var bobsOrder = new Order(DefaultData.Clients.Bob);
            bobsOrder.AddProduct(DefaultData.Products.Shirt, 2);

            var alicesOrder = new Order(DefaultData.Clients.Alice);
            alicesOrder.AddProduct(DefaultData.Products.Water, 5);
            alicesOrder.AddProduct(DefaultData.Products.Water, 2);
            alicesOrder.AddProduct(DefaultData.Products.Shirt, 3);

            context.Orders.Add(bobsOrder);
            context.Orders.Add(alicesOrder);
        }
    }
}
