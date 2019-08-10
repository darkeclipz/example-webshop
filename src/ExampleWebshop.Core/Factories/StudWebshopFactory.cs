using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class StudWebshopFactory : IWebshopFactory
    {
        public ICart InstantiateCart()
        {
            throw new NotImplementedException();
        }

        public ICatalog InstantiateCatalog()
        {
            throw new NotImplementedException();
        }

        public ICheckoutService InstantiateCheckoutService()
        {
            throw new NotImplementedException();
        }

        public IPersonRepository InstantiatePersonRepository()
        {
             throw new NotImplementedException();
        }

        public IPersonService InstantiatePersonService()
        {
            throw new NotImplementedException();
        }
    }
}
