 using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class MyprofileController : Controller
    {
        public IActionResult Index()
        {
            return View("Myprofile");
        }
    }
}
