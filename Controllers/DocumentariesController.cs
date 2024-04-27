using Microsoft.AspNetCore.Mvc;

namespace Project_MVC_StaticSite_Cloud.Controllers
{
    public class DocumentariesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
