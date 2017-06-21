using Domain.Resources;
using System;

namespace Domain.Concrete
{
    public class EntityColumn
    {
        public string Name { get; internal set; }
        public Type Type { get; internal set; }
        public Schema Schema { get; internal set; }
        public bool IsLookup { get; internal set; }
        public bool IsHidden { get; internal set; }
        public bool IsNameColumn { get; internal set; }
        public bool IsForeignKey { get; internal set; }
        public bool IsRequired { get; internal set; }
        public string Caption
        {
            get => SchemaColumnCaptions.ResourceManager.GetString(Schema.Name + "_" + 
                (IsNameColumn ? Name.Remove(Name.Length - 4) : 
                (IsForeignKey ? Name.Remove(Name.Length - 2) : Name)));
        }
    }
}
