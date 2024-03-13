using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class RolesPermissionsController : Controller
    {
        public IActionResult Index()
        {
            return View("RolesPermissions");
        }
    }
}
