using System;
using System.Configuration;
using System.Data.EntityClient;
using System.Linq;
using DTO_Mapping_Test.Context;
using DTO_Mapping_Test.Utility_Classes;
using DTO_Mapping_Test_Entities;
using Dapper;
using System.Dynamic;
using ImpromptuInterface;

namespace DTO_Mapping_Test.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private AdventureWorksContext _context;

        public PersonRepository()
        {
            _context = new AdventureWorksContext(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString);
                       

            DynamicMapper.AddMap<Person>(new Func<dynamic, string, Person>((o, s) => new Person
                                                                {
                                                                    BusinessEntityID = o.BusinessEntityID,
                                                                    FirstName = Impromptu.InvokeGet(o, string.Format("{0}FirstName", s))
                                                                }));                


        }

        public IQueryable<Person> GetPeople()
        {

            var sql = @"
select top 4 p.*, e.*
from Person.Person p
inner join HumanResources.Employee e
on p.BusinessEntityID = e.BusinessEntityID
left outer join person.businessentitycontact bec
on p.businessentityid = bec.businessentityid
";
            _context.Connection.Open();
            var person = _context.StoreConnection.Query<dynamic>(sql).Select(x => DynamicMapper.GetDynamicMap<Person>(x, "")).ToList();
            return _context.People.Include("Employee").Include("BusinessEntityContacts").Where(p => p.BusinessEntityID < 10);
        }
    }
}