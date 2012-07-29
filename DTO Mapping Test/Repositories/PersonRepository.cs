using System.Configuration;
using System.Linq;
using DTO_Mapping_Test.Context;
using DTO_Mapping_Test.Utility_Classes;
using DTO_Mapping_Test_Entities;

namespace DTO_Mapping_Test.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private AdventureWorksContext _context;

        public PersonRepository()
        {
            _context = new AdventureWorksContext(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString);
        }

        public IQueryable<Person>  GetPeople()
        {
            return _context.People.Include("Employee").Where(p => p.BusinessEntityID < 10);
        }
    }
}