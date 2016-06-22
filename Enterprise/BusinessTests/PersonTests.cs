using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Contracts.Repository;

namespace BusinessTests
{
    [TestClass]
    public class PersonTests
    {

        PersonBusiness _person;
        IPersonRepository _repo;


        public class MockRepo : IPersonRepository
        {
            public bool AddPerson(string name, DateTime joinDate)
            {
                return true;
            }
        }

        [TestInitialize]
        public void init()
        {
            _repo = new MockRepo();
            _person = new PersonBusiness(_repo);
        }

        [TestMethod]
        public void CanAddPerson()
        {
            var result = _person.AddPerson("Yunus Emre Akbulut", DateTime.Now.AddDays(-2));

            Assert.AreEqual(true, result);
        }
    }
}
