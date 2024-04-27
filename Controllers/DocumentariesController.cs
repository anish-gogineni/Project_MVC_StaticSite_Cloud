using Microsoft.AspNetCore.Mvc;

namespace Project_MVC_StaticSite_Cloud.Controllers
{
    // This is document controller
    public class DocumentariesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
