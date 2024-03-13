using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class BulkUploadController : Controller
    {
        public IActionResult Index()
        {
            return View("BulkUpload");
        }
    }
}
