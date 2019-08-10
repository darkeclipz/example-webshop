using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class ConcretePersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public ConcretePersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public Person Add(Person person)
        {
            return personRepository.Add(person);
        }

        public Person Get(string email)
        {
            return personRepository.Get(email);
        }

        public IEnumerable<Person> Get()
        {
            return personRepository.Get();
        }

        public bool Exists(string email)
        {
            return personRepository.Exists(email);
        }
    }
}
