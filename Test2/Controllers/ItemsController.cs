using Microsoft.AspNetCore.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyword" };
            return View(item);
        }
        public IActionResult Edit(int id)
        {
            return Content("Id: = " + id);
        }
    }
}
