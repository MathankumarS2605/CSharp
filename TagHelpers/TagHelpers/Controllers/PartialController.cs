using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}
