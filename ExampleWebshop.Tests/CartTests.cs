using ExampleWebshop.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ExampleWebshop.Tests
{
    [TestClass]
    public class CartTests
    {
        private readonly ICatalog catalog;
        private readonly ICart cart;

        public CartTests()
        {
            var factory = new UnitTestWebshopFactory();
            catalog = factory.InstantiateCatalog();
            cart = factory.InstantiateCart();
        }

        [TestMethod]
        public void AddItem()
        {
            var firstItem = catalog.All().First();
            cart.AddItem(firstItem);

            Assert.AreEqual(firstItem, cart.Items().First().Key);
            Assert.AreEqual(1, cart.Items().First().Value);

            cart.Clear();
            Assert.IsFalse(cart.Items().Any());
        }
    }
}
