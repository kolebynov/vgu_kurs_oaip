using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class EntityColumn
    {
        public string Name { get; internal set; }
        public Type Type { get; internal set; }
        public Schema Schema { get; internal set; }
    }
}
