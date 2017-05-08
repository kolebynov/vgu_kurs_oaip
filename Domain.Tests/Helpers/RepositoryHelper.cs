using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Model.Abstract;
using System.Data.Entity;

namespace Domain.Tests.Helpers
{
    public static class RepositoryHelper<TEntity> where TEntity : BaseModel
    {
        public static EFRepository<TEntity> GetTestEFRepository()
        {
            if (_repository == null)
            {
                _repository = new EFRepository<TEntity>(_testConnectionString);
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFDbContext<TEntity>>());
            }
            return _repository;
        }

        private static string _testConnectionString = "Data Source=HOME-PC;" +
            "Initial Catalog=vgu_kurs_oaip_test;Integrated Security=True;App=EntityFramework";
        private static EFRepository<TEntity> _repository;
    }
}
