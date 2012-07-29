using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_Mapping_Test.Repositories;

namespace DTO_Mapping_Test.Context
{
    public class UnitOfWork
    {
        private IPersonRepository _personRepository;

        public IPersonRepository PersonRepository
        {
            get { return _personRepository ?? (_personRepository = new PersonRepository()); }
        }
    }
}
