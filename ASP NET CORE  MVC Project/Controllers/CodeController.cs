using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_CORE__MVC_Project.Controllers
{
    public class CodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Java()
        {
            return View();
        }

        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult C()
        {
            return View();
        }
    }
}
