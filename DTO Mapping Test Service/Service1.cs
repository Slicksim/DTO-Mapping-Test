using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO_Mapping_Test.Context;
using DTO_Mapping_Test.Utility_Classes;
using DTO_Mapping_Test_Entities.DTOs;

namespace DTO_Mapping_Test_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1
    {
        private UnitOfWork _unitOfWork;

        public Service1()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IList<Person> People()
        {
            return _unitOfWork.PersonRepository.GetPeople().Project().To<Person>().ToList();
        }
    }
}
