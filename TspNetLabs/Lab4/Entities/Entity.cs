using System;

namespace Lab4.Entities
{
    internal abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Deleted { get; private set; }

        public void Delete() => this.Deleted = true;
    }
}