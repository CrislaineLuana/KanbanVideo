using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KanbanVideo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
