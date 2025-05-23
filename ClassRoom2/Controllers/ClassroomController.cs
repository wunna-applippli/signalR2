using Microsoft.AspNetCore.Mvc;

namespace ClassRoom2.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
