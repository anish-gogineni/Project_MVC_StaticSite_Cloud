using Microsoft.AspNetCore.Mvc;
using Project_MVC_StaticSite_Cloud.Models;

//This is movie controller
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
