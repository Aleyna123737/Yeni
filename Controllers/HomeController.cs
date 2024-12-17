using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Authorization;


namespace UIApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
