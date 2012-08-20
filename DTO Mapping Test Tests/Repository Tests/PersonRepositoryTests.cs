using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DTO_Mapping_Test.Repositories;
using DTO_Mapping_Test.Utility_Classes;
using DTO_Mapping_Test_Entities.DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DTO_Mapping_Test_Tests.Repository_Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        private PersonRepository _repository;


        [TestInitialize]
        public void BeforeAll()
        {
            _repository = new PersonRepository();
        }

        [TestMethod]
        public void PersonRepository_CanGetPeople()
        {
            var people = _repository.GetPeople();

            var query = (ObjectQuery) people;
            // start a loop

            // loop over the items
           
            var projected = people.Project().To<Person>();

            var otherQuery = (ObjectQuery) projected;

            //var projectedList = projected.ToList();

        }
    }
}
