using Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        public bool AddPerson(string name, DateTime joinDate)
        {
            return true;
        }
    }
}
