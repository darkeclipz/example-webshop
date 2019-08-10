using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    internal class MemoryPersonRepository : MemoryRepository<Person, string>, IPersonRepository
    {
        public bool Exists(string email)
        {
            return entities.Any(e => e.Email == email);
        }
    }
}
