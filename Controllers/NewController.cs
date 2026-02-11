using Microsoft.AspNetCore.Mvc;

namespace Hospital_Managment.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
