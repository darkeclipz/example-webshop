using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    class ConcreteCatalog : ICatalog
    {
        private readonly IItemRepository itemRepository;

        public ConcreteCatalog(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public IEnumerable<Item> All()
        {
            return itemRepository.Get();
        }

        public Item Get(int id)
        {
            return itemRepository.Get(id);
        }
    }
}
