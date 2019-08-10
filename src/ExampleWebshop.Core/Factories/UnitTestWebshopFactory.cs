using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class UnitTestWebshopFactory : IWebshopFactory
    {
        public ICart InstantiateCart()
        {
            return new ConcreteCart();
        }

        public ICatalog InstantiateCatalog()
        {
            var repository = new MemoryItemRepository();
            return new ConcreteCatalog(repository);
        }

        public ICheckoutService InstantiateCheckoutService()
        {
            var repository = new MemoryOrderRepository();
            var service = new ConcreteCheckoutService(repository);
            return service;
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
