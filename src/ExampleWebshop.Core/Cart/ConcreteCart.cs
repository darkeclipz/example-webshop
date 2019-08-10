using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    class ConcreteCart : ICart
    {
        private readonly IDictionary<Item, int> items;

        public ConcreteCart()
        {
            items = new Dictionary<Item, int>();
        }

        public void AddItem(Item item, int quantity = 1)
        {
            if (items.ContainsKey(item))
            {
                items[item] += quantity;
            }
            else
            {
                items.Add(item, quantity);
            }
        }

        public void RemoveItem(Item item, int quantity = 1)
        {
            if (items.ContainsKey(item))
            {
                items[item] -= quantity;

                if (items[item] <= 0)
                {
                    items.Remove(item);
                }
            }
        }

        public IEnumerable<KeyValuePair<Item, int>> Items()
        {
            return items.ToList();
        }

        public void Clear()
        {
            items.Clear();
        }

        public decimal CalculateTotal()
        {
            return items.Sum(i => i.Key.Price * i.Value);
        }
    }
}
