using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HR.Models
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branche> Branches { get; set; }
    }
}
