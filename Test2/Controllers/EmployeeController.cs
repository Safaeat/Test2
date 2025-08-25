using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Test2.Data;
using Test2.Models;

namespace Test2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _Db;
        public EmployeeController(EmployeeDBContext context)
        {
            this._Db = context;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _Db.Employees.ToListAsync();
            return View(employees);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee Obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Add(Obj);
                await _Db.SaveChangesAsync();
                TempData["EmpSuccess"] = "Employee information added successfully.";
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _Db.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Employee Obj)
        {
            if (id != Obj.Emp_ID)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _Db.Update(Obj);
                await _Db.SaveChangesAsync();
                TempData["EmpSuccess"] = "Employee information updated successfully.";
                return RedirectToAction("Index");
            }
            return View(Obj);
        }
    }
}