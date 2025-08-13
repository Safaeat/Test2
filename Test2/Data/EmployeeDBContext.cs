using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
