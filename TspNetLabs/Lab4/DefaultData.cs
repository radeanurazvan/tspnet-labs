using Lab4.Entities;

namespace Lab4
{
    internal static class DefaultData
    {
        public static class Products
        {
            public static Product Shirt  = new Product(nameof(Shirt), 40);
            public static Product Water  = new Product(nameof(Water), 3);
        }

        public static class Clients
        {
            public static Client Bob = new Client(nameof(Bob), "bob@gmail.com");
            public static Client Alice = new Client(nameof(Alice), "alice@gmail.com");
        }
    }
}