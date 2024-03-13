using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class NotificationsController : Controller
    {
        [Route("Notifications")]
        public IActionResult Notifications()
        {
          

            return View("Notifications");

        }
    }
}
