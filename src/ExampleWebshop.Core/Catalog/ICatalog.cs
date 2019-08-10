using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface ICatalog
    {
        Item Get(int id);
        IEnumerable<Item> All();
    }
}
