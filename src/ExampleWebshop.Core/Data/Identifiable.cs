using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    interface IIdentifiable<T>
    {
        T GetIdentifier();
    }
}
