using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebshop.Core;
using ExampleWebshop.UI.Web.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleWebshop.UI.Web.Pages
{
    public class LoginModel : PageModel
    {
        public string ReturnUrl = "";
        public string LoginError = string.Empty;
        public string SignupError = string.Empty;

        private readonly UserStore userStore;

        [BindProperty]
        public LoginViewModel LoginViewModel { get; set; }

        [BindProperty]
        public SignupViewModel SignupViewModel { get; set; }

        public LoginModel(IHttpContextAccessor httpContextAccessor, UserStore userStore)
        {
            ReturnUrl = httpContextAccessor.HttpContext.Request.Headers["Referer"];

            if (httpContextAccessor.HttpContext.Request.Query.Keys.Contains("returnUrl"))
            {
                ReturnUrl = httpContextAccessor.HttpContext.Request.Query["returnUrl"].ToString();
            }

            this.userStore = userStore;
        }

        public IActionResult OnPost()
        {
            if(userStore.Validate(LoginViewModel.Email, LoginViewModel.Password))
            {
                return Login(LoginViewModel.Email, LoginViewModel.ReturnUrl);   
            }
            else
            {
                LoginError = "Invalid username or password.";
                return new PageResult();
            }
        }

        public IActionResult OnPostSignup()
        {
            var person = new Person
            {
                Email = SignupViewModel.Email,
                FirstName = SignupViewModel.FirstName,
                LastName = SignupViewModel.LastName,
                AddressLine1 = $"{SignupViewModel.StreetName} {SignupViewModel.HouseNumber}",
                AddressLine2 = $"{SignupViewModel.PostalCode} {SignupViewModel.City}",
                AddressLine3 = SignupViewModel.Country
            };

            if(!userStore.Register(person, SignupViewModel.Password))
            {
                SignupError = "The user already exists, please use different e-mail address.";
                return new PageResult();
            }

            return Login(person.Email, SignupViewModel.ReturnUrl);
        }

        public IActionResult OnPostLogout()
        {
            return Logout();
        }

        private IActionResult Login(string email, string returnUrl)
        {
            HttpContext.Session.SetString("email", email);
            return Redirect(returnUrl);
        }

        private IActionResult Logout()
        {
            HttpContext.Session.Remove("email");
            return Redirect("/");
        }
    }
}