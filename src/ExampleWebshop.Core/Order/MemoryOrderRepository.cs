using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    class MemoryOrderRepository : MemoryRepository<Order, Guid>, IOrderRepository { }
}
