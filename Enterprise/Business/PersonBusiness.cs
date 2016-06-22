using Contracts.Repository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonBusiness
    {

        IPersonRepository _personRepo = null;

        public PersonBusiness(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public bool AddPerson(string name, DateTime joinDate)
        {
            var x = _personRepo.AddPerson(name, joinDate);
            return x;
        }
    }
}
