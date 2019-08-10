using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IOrderRepository : IRepository<Order, Guid> { }
}
