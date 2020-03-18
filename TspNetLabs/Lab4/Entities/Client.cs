using System.Collections.Generic;

namespace Lab4.Entities
{
    internal sealed class Client : Entity
    {
        private Client()
        {
        }

        public Client(string name, string email)
            : this()
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public ICollection<Order> Orders { get; private set; } = new List<Order>();
    }
}