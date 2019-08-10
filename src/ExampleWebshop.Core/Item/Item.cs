using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public class Item : IIdentifiable<int>
    {
        public int Id;
        public string Name;
        public string Description;
        public decimal Price;

        public int GetIdentifier()
        {
            return Id;
        }
    }
}
