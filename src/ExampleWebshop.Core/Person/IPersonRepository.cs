using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IPersonRepository : IRepository<Person, string>
    {
        bool Exists(string email);
    }
}
