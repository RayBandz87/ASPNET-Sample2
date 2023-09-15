using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNET.Pages
{
    public class WebForms : PageModel
    {
        private readonly ILogger<WebForms> _logger;

        public WebForms(ILogger<WebForms> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}