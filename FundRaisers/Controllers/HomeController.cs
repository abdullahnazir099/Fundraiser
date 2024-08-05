using Microsoft.AspNetCore.Mvc;

namespace FundRaisers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
