using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IItemRepository : IRepository<Item, int> { }
}
