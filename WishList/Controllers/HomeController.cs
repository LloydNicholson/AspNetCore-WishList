using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
        
        [HttpGet]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
