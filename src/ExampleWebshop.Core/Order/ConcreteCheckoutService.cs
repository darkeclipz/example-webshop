using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    class ConcreteCheckoutService : ICheckoutService
    {
        private readonly IOrderRepository orderRepository;

        public ConcreteCheckoutService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order Checkout(ICart cart, Person person)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                Lines = cart.Items().Select(i => new OrderLine { Item = i.Key, Quantity = i.Value }).ToList(),
                Person = person
            };

            orderRepository.Add(order);
            cart.Clear();

            return order;
        }
    }
}
