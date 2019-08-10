using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebshop.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleWebshop.UI.Web.Pages
{
    public class CartModel : PageModel
    {
        private readonly ICatalog catalog;
        public ICart Cart;

        [BindProperty]
        public CartViewModel CartViewModel { get; set; }

        public CartModel(IHttpContextAccessor httpContextAccessor, ICatalog catalog)
        {
            Cart = httpContextAccessor.HttpContext.GetCart();
            this.catalog = catalog;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var item = catalog.Get(CartViewModel.ItemId);
            Cart.AddItem(item, CartViewModel.Quantity);
        }

        public void OnPostDelete()
        {
            var item = catalog.Get(CartViewModel.ItemId);
            Cart.RemoveItem(item, CartViewModel.Quantity);
        }

        public void OnPostQuantity()
        {
            var item = catalog.Get(CartViewModel.ItemId);
            
            if(CartViewModel.Quantity >= 0)
            {
                Cart.AddItem(item);
            }
            else
            {
                Cart.RemoveItem(item);
            }
        }

        public void OnPostClear()
        {
            Cart.Clear();
        }
    }
}