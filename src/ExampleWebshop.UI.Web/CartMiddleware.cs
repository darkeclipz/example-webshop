using ExampleWebshop.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ExampleWebshop.UI.Web
{
    public class CartMiddleware
    {
        private readonly RequestDelegate _next;

        public CartMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Session.SetString("session_id", httpContext.Session.Id);
            var cartManager = (CartManager)httpContext.RequestServices.GetService(typeof(CartManager));
            if (!cartManager.HasCart(httpContext.Session.Id))
            {
                var factory = (IWebshopFactory)httpContext.RequestServices.GetService(typeof(IWebshopFactory));
                var cart = factory.InstantiateCart();
                httpContext.SetCart(cart);
            }

            return _next(httpContext);
        }
    }

    public static class CartMiddlewareExtensions
    {
        public static IApplicationBuilder UseCartMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CartMiddleware>();
        }

        public static ICart GetCart(this HttpContext context)
        {
            var cartManager = (CartManager)context.RequestServices.GetService(typeof(CartManager));
            return cartManager.GetCart(context.Session.Id);
        }

        public static void SetCart(this HttpContext context, ICart cart)
        {
            var cartManager = (CartManager)context.RequestServices.GetService(typeof(CartManager));
            cartManager.AddCart(context.Session.Id, cart);
        }

        public static bool IsLoggedIn(this HttpContext context)
        {
            return context.Session.Keys.Contains("email");
        }
    }

    public class SerializableCartWrapper 
    {
        public ICart Cart;

        public SerializableCartWrapper(ICart cart)
        {
            this.Cart = cart;
        }
    }
}
