using Microsoft.AspNetCore.Mvc;

//This is Tv controller
namespace Project_MVC_StaticSite_Cloud.Controllers
{
    public class TV_ShowsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
