using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ConceptCollector.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
