using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;
using System.Configuration;

namespace Domain.Concrete
{
    public class EFDbContext<T> : DbContext where T : BaseEntity
    {
        public DbSet<T> Entities { get; set; }

        public EFDbContext()
        {
            Database.Connection.ConnectionString = 
                ConfigurationManager.ConnectionStrings["EFDbContext"].ConnectionString;
        }
    }
}
