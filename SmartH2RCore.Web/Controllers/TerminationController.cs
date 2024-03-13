using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class TerminationController : Controller
    {
        public IActionResult Index()
        {
            return View("Termination");
        }
    }
}
