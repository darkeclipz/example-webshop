using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface ICheckoutService
    {
        Order Checkout(ICart cart, Person person);
    }
}
