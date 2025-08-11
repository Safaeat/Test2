using Microsoft.AspNetCore.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            var design = new Design() { Name = "keyword" };
            return View(design);
        }
    }
}
