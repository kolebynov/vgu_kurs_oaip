using Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class RequiredColumnException : Exception
    {
        public BaseModel Entity { get; }
        public EntityColumn RequiredColumn { get; }

        public RequiredColumnException(BaseModel entity, EntityColumn requiredColumn) : 
            this(null, entity, requiredColumn)
        { }
        public RequiredColumnException(string message, BaseModel entity, 
            EntityColumn requiredColumn) : this(message, null, entity, requiredColumn)
        { }
        public RequiredColumnException(string message, Exception innerException, 
            BaseModel entity, EntityColumn requiredColumn) : base(message, innerException)
        {
            Entity = entity;
            RequiredColumn = requiredColumn;
        }
    }
}
