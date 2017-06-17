using System;
using System.Collections.Generic;
using Domain.Resources;

namespace Domain.Concrete
{
    public class Schema
    {
        public string Name { get; internal set; }
        public Type Type { get; internal set; }
        public List<EntityColumn> Columns { get; internal set; }
        public EntityColumn PrimaryColumn { get; internal set; }
        public EntityColumn DisplayColumn { get; internal set; }
        public string Caption
        {
            get => SchemaCaptions.ResourceManager.GetString(Name + "Caption");
        }
    }
}
