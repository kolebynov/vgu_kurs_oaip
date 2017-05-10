using System;

namespace Domain.Entity
{
    public class EntityColumn
    {
        public string Name { get; internal set; }
        public Type Type { get; internal set; }
        public Schema Schema { get; internal set; }
    }
}
