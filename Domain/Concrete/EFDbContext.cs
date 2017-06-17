using Domain.Model;
using Domain.Model.Abstract;
using System.Data.Entity;

namespace Domain.Concrete
{
    public class EFDbContext<T> : DbContext where T : BaseModel
    {
        public DbSet<T> Entities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasOptional(c => c.CreatedBy).WithMany().HasForeignKey(c => c.CreatedById);
            modelBuilder.Entity<Contact>().HasOptional(c => c.ModifiedBy).WithMany().HasForeignKey(c => c.ModifiedById);
            modelBuilder.Entity<BookedTour>();
            modelBuilder.Entity<City>();
            modelBuilder.Entity<Country>();
            modelBuilder.Entity<Gender>();
            modelBuilder.Entity<Tour>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
