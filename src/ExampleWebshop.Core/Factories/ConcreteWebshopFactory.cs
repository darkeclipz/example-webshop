using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class ConcreteWebshopFactory : IWebshopFactory
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
            var repository = new TextOrderRepository();
            var service = new ConcreteCheckoutService(repository);
            return service;
        }

        public IPersonService InstantiatePersonService()
        {
            var repository = new TextPersonRepository();
            return new ConcretePersonService(repository);
        }
    }
}
