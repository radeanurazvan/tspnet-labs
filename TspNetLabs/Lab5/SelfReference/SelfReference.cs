using System;
using System.Collections.Generic;

namespace Lab5.SelfReference
{
    public class SelfReference : Entity
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        public SelfReference Parent { get; set; }

        public ICollection<SelfReference> Children { get; set; }
    }
}