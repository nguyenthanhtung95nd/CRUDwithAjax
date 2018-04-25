using CRUDAjax.Models;
using System.Data.Entity;

namespace CRUDAjax
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeConnectionString")
        {
        }

        public DbSet<Employee> Employees { set; get; }
    }
}