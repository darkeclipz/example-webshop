using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebshop.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleWebshop.UI.Web.Pages
{
    public class IndexModel : PageModel
    {
        public readonly ICatalog Catalog;

        public IndexModel(ICatalog catalog)
        {
            this.Catalog = catalog;
        }

        public void OnGet()
        {
        }
    }
}
