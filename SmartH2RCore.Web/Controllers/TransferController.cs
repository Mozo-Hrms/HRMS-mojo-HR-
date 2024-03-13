using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class TransferController : Controller
    {
        public IActionResult Index()
        {
            return View("Transfer");
        }
    }
}
