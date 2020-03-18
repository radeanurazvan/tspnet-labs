using System;

namespace Lab5.InheritanceSharedTable
{
    public class Business : Entity
    {
        public string Name { get; set; }
    }

    public class Retail : Entity
    {
        public string City { get; set; }

        public string Address { get; set; }

        public Guid BusinessId { get; set; }

        public Business Business { get; set; }
    }

    public class Ecommerce : Entity
    {
        public string Url { get; set; }

        public Guid BusinessId { get; set; }

        public Business Business { get; set; }
    }
}