using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class ResignationController : Controller
    {
        public IActionResult Index()
        {
            return View("Resignation");
        }
    }
}
