using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Test2.Data;

namespace Test2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _Db;
        public EmployeeController(EmployeeDBContext context)
        {
            this._Db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}