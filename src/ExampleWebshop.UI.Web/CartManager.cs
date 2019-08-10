using ExampleWebshop.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleWebshop.UI.Web
{
    public class CartManager
    {
        private IDictionary<string, ICart> carts;

        public CartManager()
        {
            carts = new Dictionary<string, ICart>();
        }

        public void AddCart(string sessionId, ICart cart)
        {
            if(carts.Keys.Contains(sessionId))
            {
                carts.Remove(sessionId);
            }

            carts.Add(sessionId, cart);
        }

        public bool HasCart(string sessionId)
            => carts.ContainsKey(sessionId);

        public ICart GetCart(string sessionId) => carts[sessionId];
    }
}
