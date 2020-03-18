using System;
using System.Collections.Generic;

namespace Lab4.Entities
{
    internal sealed class Order : Entity
    {
        private Order()
        {
        }

        public Order(Client client)
            : this()
        {
            Client = client;
            ClientId = client.Id;
        }

        public ICollection<OrderDetail> OrderDetails { get; private set; } = new List<OrderDetail>();

        public Guid ClientId { get; private set; }

        public Client Client { get; private set; }

        public void AddProduct(Product product, int quantity)
        {
            OrderDetails.Add(new OrderDetail(product, quantity));
        }
    }
}