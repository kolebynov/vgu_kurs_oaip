using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Tests.Helpers;
using Domain.Model;
using System.Linq;
using Domain.Concrete;

namespace Domain.Tests.Concrete
{
    [TestClass]
    public class EFRepositoryTest
    {
        [TestMethod]
        public void Can_Add_Record()
        {
            //Arrange
            var repository = RepositoryHelper<Country>.GetTestEFRepository();
            var id = Guid.NewGuid();
            var country = new Country()
            {
                Id = id,
                Name = "Беларусь"
            };

            //Act
            repository.Insert(country);
            var dbEntry = repository.Entities.FirstOrDefault(c => c.Id == id);

            //Assert
            Assert.IsNotNull(dbEntry);
            Assert.AreEqual(id, dbEntry.Id);
            Assert.AreEqual("Беларусь", dbEntry.Name);
        }
        [TestMethod]
        public void Can_Update_Record()
        {
            //Arrange
            var repository = RepositoryHelper<Country>.GetTestEFRepository();
            var country = AddTestCountry(repository);

            //Act
            country.Name = "Россия";
            repository.Update(country);
            var dbEntry = repository.Entities.FirstOrDefault(c => c.Id == country.Id);

            //Assert
            Assert.IsNotNull(dbEntry);
            Assert.AreEqual(country.Id, dbEntry.Id);
            Assert.AreEqual(country.Name, dbEntry.Name);
        }
        [TestMethod]
        public void Can_Delete_Record()
        {
            //Arrange
            var repository = RepositoryHelper<Country>.GetTestEFRepository();
            var country = AddTestCountry(repository);

            //Act
            repository.Delete(country.Id);
            var deletedCountry = repository.Entities.FirstOrDefault(c => c.Id == country.Id);

            //Assert
            Assert.IsNull(deletedCountry);
        }

        private Country AddTestCountry(EFRepository<Country> repository)
        {
            var id = Guid.NewGuid();
            var country = new Country()
            {
                Id = id,
                Name = "Беларусь"
            };
            repository.DBContext.Entities.Add(country);
            repository.DBContext.SaveChanges();

            return country;
        }
    }
}
