using Domain.Model.Abstract;
using System.Linq;

namespace Domain.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        IQueryable<TEntity> Entities { get; }

        void Insert(TEntity entity);
        void Update(TEntity entity);
        TEntity Delete(object primaryKeyValue);
    }
}
