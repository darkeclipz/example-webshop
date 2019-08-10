using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IWebshopFactory
    {
        ICart InstantiateCart();
        ICatalog InstantiateCatalog();
        ICheckoutService InstantiateCheckoutService();
        IPersonService InstantiatePersonService();
    }
}
