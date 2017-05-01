using System;
using System.Linq;
using Domain.Abstract;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Domain.Resources;
using Domain.Attributes;

namespace Domain.Concrete
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
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
            TEntity dbEntry = m_context.Entities.Find(m_primaryKeyProperty.GetValue(entity));
            if (dbEntry != null)
            {
                foreach (PropertyInfo property in m_entityProperties)
                    property.SetValue(dbEntry, property.GetValue(entity));
            }
            m_context.SaveChanges();
        }
        public TEntity Delete(object primaryKeyValue)
        {
            TEntity dbEntry = m_context.Entities.Find(primaryKeyValue);
            if (dbEntry != null)
            {
                m_context.Entities.Remove(dbEntry);
                m_context.SaveChanges();
            }
            return dbEntry;
        }

        private PropertyInfo[] m_entityProperties;
        private EFDbContext<TEntity> m_context = new EFDbContext<TEntity>();
        private PropertyInfo m_primaryKeyProperty;

        private void LoadProperties()
        {
            Type entityType = typeof(TEntity);
            m_entityProperties = entityType.GetProperties().Where(property =>
                property.GetCustomAttribute<NavPropertyAttribute>() == null).ToArray();
            m_primaryKeyProperty = m_entityProperties.FirstOrDefault(property =>
                property.GetCustomAttribute<KeyAttribute>() != null) ??
                throw new InvalidOperationException(string.Format(DomainResources.PrimaryColumnNotFoundFormat,
                entityType.Name));
        }
    }
}
