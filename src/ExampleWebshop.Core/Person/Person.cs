using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class Person : IIdentifiable<string>
    {
        public string Email;
        public string FirstName;
        public string LastName;
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;

        public string GetIdentifier()
        {
            return Email;
        }
    }
}
