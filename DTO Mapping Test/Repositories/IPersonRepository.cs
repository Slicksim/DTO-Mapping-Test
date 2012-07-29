using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_Mapping_Test_Entities;

namespace DTO_Mapping_Test.Repositories
{
    public interface IPersonRepository
    {
        IQueryable<Person>  GetPeople();
    }
}
