using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface ICart
    {
        IEnumerable<KeyValuePair<Item, int>> Items();
        void AddItem(Item item, int quantity = 1);
        decimal CalculateTotal();
        void RemoveItem(Item item, int quantity = 1);
        void Clear();
    }
}
