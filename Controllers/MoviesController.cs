using Microsoft.AspNetCore.Mvc;
using Project_MVC_StaticSite_Cloud.Models;

namespace Project_MVC_StaticSite_Cloud.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
