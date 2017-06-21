using Domain.Abstract;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Infrastructure
{
    public static class FilterHelper
    {
        public static IEnumerable<City> GetCitiesByCountry(Guid countyId)
        {
            IRepository<City> repository = Factory.GetInstance<IRepository<City>>(true);
            if (countyId == Guid.Empty)
                return repository.Entities.ToList();
            else
                return repository.Entities.Where(city => city.CountryId == countyId).ToList();
        }
    }
}
