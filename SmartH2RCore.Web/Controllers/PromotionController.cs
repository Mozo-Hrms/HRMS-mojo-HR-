using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View("Promotion");
        }
    }
}
