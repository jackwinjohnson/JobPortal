using JobPortal.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<WorkExprience> WorkExpriences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Address> EmployeeSkills { get; set; }
        public  DbSet<AppUser>AppUser { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Empolyer> Empolyers { get; set; }
        public DbSet<ExperinceLevel> ExperinceLevels { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }

        






    }
}
