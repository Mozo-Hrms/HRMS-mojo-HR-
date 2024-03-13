using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class MYorgchartController : Controller
    {
        public IActionResult Index()
        {
            return View("MYorgchart");
        }
    }
}
