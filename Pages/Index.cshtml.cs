using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PortfolioWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger){
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        public void OnGet(){
            // This is what renders the page
            if (string.IsNullOrWhiteSpace(City))
                City = "The Web";
        }

        // Post is what runs when you post data to the page
    }
}
