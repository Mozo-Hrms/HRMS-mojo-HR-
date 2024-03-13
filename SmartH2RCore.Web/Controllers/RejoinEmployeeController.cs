using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class RejoinEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("RejoinEmployee");
        }
    }
}
