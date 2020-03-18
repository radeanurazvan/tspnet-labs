using System;

namespace Lab4.Entities
{
    internal sealed class OrderDetail : Entity
    {
        private OrderDetail()
        {
        }

        internal OrderDetail(Product product, int quantity)
            : this()
        {
            ProductId = product.Id;
            Product = product;
            Quantity = quantity;
        }

        public Guid ProductId { get; private set; }

        public Product Product { get; private set; }

        public int Quantity { get; private set; }

        public Guid OrderId { get; private set; }

        public Order Order { get; private set; }
    }
}