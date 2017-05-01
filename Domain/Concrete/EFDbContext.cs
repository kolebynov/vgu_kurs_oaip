using System.Data.Entity;
using System.Configuration;

namespace Domain.Concrete
{
    public class EFDbContext<T> : DbContext where T : class
    {
        public DbSet<T> Entities { get; set; }

        public EFDbContext()
        {
            Database.Connection.ConnectionString = 
                ConfigurationManager.ConnectionStrings["EFDbContext"].ConnectionString;
        }
    }
}
