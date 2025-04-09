using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    /*
     Define Database Context Class
        => Create DataBase
        =>1) Define Connection String
        =>2) Inherit from DbContext Class
        =>3) Define DbSet<T> Properties for each Entity
     */
    public class EnterpriseContext : DbContext
    {
        //Define Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=EnterpriseDB;Integrated Security=true;TrustServerCertificate=True");


        //=> Define DbSet<T> Property for each Entity(Sequence Representation for each table)
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<TrainingCourse> Courses { get; set; }
    }
}
