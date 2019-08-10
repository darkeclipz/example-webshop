using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebshop.Core;
using ExampleWebshop.UI.Web.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleWebshop.UI.Web.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly UserStore userStore;
        private readonly ICheckoutService checkoutService;

        public ICart Cart { get; set; }
        public Person Person { get; set; }

        public CheckoutModel(UserStore userStore, ICheckoutService checkoutService)
        {
            this.userStore = userStore;
            this.checkoutService = checkoutService;
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (!context.HttpContext.IsLoggedIn())
            {
                context.Result = new RedirectResult("/login?returnUrl=Checkout");
            }
            else
            {
                Initialize();
            }
            
            base.OnPageHandlerExecuting(context);
        }

        private void Initialize()
        {
            Cart = HttpContext.GetCart();
            Person = userStore.GetPerson(HttpContext.Session.GetString("email"));
        }

        public IActionResult OnPost()
        {
            checkoutService.Checkout(Cart, Person);
            return RedirectToPage("PostCheckout");
        }
    }
}