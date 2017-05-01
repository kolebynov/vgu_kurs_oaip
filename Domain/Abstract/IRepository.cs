using System;
using System.Linq;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Entities { get; }

        void Insert(TEntity entity);
        void Update(TEntity entity);
        TEntity Delete(Guid id);
    }
}
