using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IPersonService
    {
        Person Add(Person person);
        Person Get(string email);
        IEnumerable<Person> Get();
        bool Exists(string email);
    }
}
