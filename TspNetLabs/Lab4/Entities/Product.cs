namespace Lab4.Entities
{
    internal sealed class Product : Entity
    {
        private Product()
        {
        }

        public Product(string name, int price)
            : this()
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }

        public int Price { get; private set; }
    }
}