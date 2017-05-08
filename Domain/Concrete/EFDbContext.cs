using System.Data.Entity;
using Domain.Model.Abstract;
using Domain.Model;

namespace Domain.Entity
{
    public class EFDbContext<T> : DbContext where T : BaseModel
    {
        public DbSet<T> Entities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasOptional(c => c.CreatedBy).WithMany().HasForeignKey(c => c.CreatedById);
            modelBuilder.Entity<Contact>().HasOptional(c => c.ModifiedBy).WithMany().HasForeignKey(c => c.ModifiedById);
            base.OnModelCreating(modelBuilder);
        }
    }
}
