using System;
using System.Linq;
using Domain.Abstract;
using Domain.Entities;
using System.Reflection;

namespace Domain.Concrete
{
    public class EFRepository<TEntity> :
        IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> Entities => m_context.Entities;

        public EFRepository()
        {
            LoadProperties();
        }

        public void Insert(TEntity entity)
        {
            m_context.Entities.Add(entity);
            m_context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            TEntity dbEntry = m_context.Entities.Find(entity.Id);
            if (dbEntry != null)
            {
                foreach (PropertyInfo property in m_entityProperties)
                    property.SetValue(dbEntry, property.GetValue(entity));
            }
            m_context.SaveChanges();
        }
        public TEntity Delete(Guid id)
        {
            TEntity dbEntry = m_context.Entities.Find(id);
            if (dbEntry != null)
            {
                m_context.Entities.Remove(dbEntry);
                m_context.SaveChanges();
            }
            return dbEntry;
        }

        private PropertyInfo[] m_entityProperties;
        private EFDbContext<TEntity> m_context = new EFDbContext<TEntity>();

        private void LoadProperties()
        {
            Type entityType = typeof(TEntity);
            m_entityProperties = entityType.GetProperties();
        }
    }
}
