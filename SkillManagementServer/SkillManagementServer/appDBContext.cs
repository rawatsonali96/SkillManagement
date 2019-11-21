using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.EmployeeDetails;

namespace SkillManagementServer
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<EmployeeDetails> employeedetails { get; set; }
        //public DbSet<EmployeeDetails>
    }
}
