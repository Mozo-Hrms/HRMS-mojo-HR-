using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class AttendanceDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
