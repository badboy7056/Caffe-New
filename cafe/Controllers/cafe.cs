using Microsoft.AspNetCore.Mvc;

namespace cafe.Controllers
{
    public class cafe : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
