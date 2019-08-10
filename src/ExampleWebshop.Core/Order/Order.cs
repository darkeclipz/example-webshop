using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class Order : IIdentifiable<Guid>
    {
        public Guid Id;
        public OrderStatus Status;
        public IList<OrderLine> Lines;
        public Person Person;

        public Guid GetIdentifier()
        {
            return Id;
        }
    }

    public class OrderLine
    {
        public Item Item;
        public int Quantity;
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Arrived
    }
}
