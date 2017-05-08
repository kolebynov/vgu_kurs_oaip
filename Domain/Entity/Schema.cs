using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Schema
    {
        public string Name { get; internal set; }
        public Type EntityType { get; internal set; }
        public List<EntityColumn> Columns { get; internal set; }
        public EntityColumn PrimaryColumn { get; internal set; }
    }
}
