using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel//parent class in the asp .net
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string msg= "My first Response";
            Response.Redirect("Home");
        }
    }
}