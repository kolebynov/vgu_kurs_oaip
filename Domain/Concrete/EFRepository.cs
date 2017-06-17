using Domain.Abstract;
using Domain.Model.Abstract;
using System.Configuration;
using System.Linq;

namespace Domain.Concrete
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        public IQueryable<TEntity> Entities => m_context.Entities;
        public EFDbContext<TEntity> DBContext => m_context;

        public EFRepository() : 
            this(ConfigurationManager.ConnectionStrings["EFDbContext"].ConnectionString)
        { }
        public EFRepository(string connString)
        {
            m_context.Database.Connection.ConnectionString = connString;
        }

        public void Insert(TEntity entity)
        {
            entity.OnInserting();
            m_context.Entities.Add(entity);
            m_context.SaveChanges();
            entity.OnInserted();
        }
        public void Update(TEntity entity)
        {
            TEntity dbEntry = m_context.Entities.Find(entity.GetPrimaryColumnValue());
            if (dbEntry != null)
            {
                foreach (EntityColumn column in dbEntry.Schema.Columns)
                    dbEntry.SetColumnValue(column, entity.GetColumnValue(column.Name));

                dbEntry.OnUpdating();
                m_context.SaveChanges();
                dbEntry.OnUpdated();
            }
        }
        public TEntity Delete(object primaryKeyValue)
        {
            TEntity dbEntry = m_context.Entities.Find(primaryKeyValue);
            if (dbEntry != null)
            {
                dbEntry.OnDeleting();
                m_context.Entities.Remove(dbEntry);
                m_context.SaveChanges();
                dbEntry.OnDeleted();
            }
            return dbEntry;
        }

        private EFDbContext<TEntity> m_context = new EFDbContext<TEntity>();
    }
}
