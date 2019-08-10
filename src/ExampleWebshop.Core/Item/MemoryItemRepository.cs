using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    class MemoryItemRepository : MemoryRepository<Item, int>, IItemRepository
    {
        private IList<Item> examples = new List<Item>
        {
            new Item { Id = 1, Name = "Cookies", Price = 1.25m, Description = "Lorem ipsum dolor amitos." },
            new Item { Id = 2, Name = "Banana", Price = 0.99m, Description = "Lorem ipsum dolor amitos." },
            new Item { Id = 3, Name = "Tea", Price = 2.80m, Description = "Lorem ipsum dolor amitos." },
            new Item { Id = 4, Name = "Coffee", Price = 8.75m, Description = "Lorem ipsum dolor amitos." },
            new Item { Id = 5, Name = "Chips Natural", Price = 1.60m, Description = "Lorem ipsum dolor amitos." }
        };

        public MemoryItemRepository()
        {
            entities = examples;
        }
        
        public override Item Add(Item entity)
        {
            entity.Id = entities.Count;
            return base.Add(entity);
        }
    }
}
