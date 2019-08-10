using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    class TextOrderRepository : TextRepository<Order, Guid>, IOrderRepository { }
}
