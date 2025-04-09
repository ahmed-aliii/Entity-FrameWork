using D02CompanyDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class CompanyDBContext : DbContext
    {
        //Connetion String => Pipeline to Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=.;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=True"); 
    


        // Enforce Validation in business Layer before sending to Database => Save Changes Override
        public override int SaveChanges()
        {
            var Entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added || e.State == EntityState.Modified
                           select e.Entity;

            foreach (var entity in Entities)
            {
                ValidationContext validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext, true);
            }

            return base.SaveChanges();
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Model Builder Old Code
            //modelBuilder.Entity<Department>()
            //        .HasKey(dept => dept.deptID); //Primary Key


            //modelBuilder.Entity<Department>()
            //    .Property(dept => dept.Name)
            //    .IsRequired() //Not Null
            //    .HasMaxLength(50); //nvarchar(50)

            //modelBuilder.Entity<Department>()
            //    .Property(dept => dept.YearOfCreation)
            //    .HasDefaultValue(DateTime.Now.Year); //Default Value
            //                                         //.HasAnnotation("MaxLength" , 4);   //Add annotation using Fluent API 
            #endregion

            #region Fluent API
            //modelBuilder.Entity<Department>(EntityBuilder =>
            //    {
            //        EntityBuilder.HasKey(dept => dept.deptID);

            //        EntityBuilder.Property(dept => dept.Name)
            //                    .IsRequired() //Not Null
            //                    .HasMaxLength(50); //nvarchar(50)

            //        EntityBuilder.Property(dept => dept.YearOfCreation)
            //                     .HasDefaultValue(DateTime.Now.Year);
            //    }); 
            #endregion

            //Add Configuration Class for Department Entity 
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            #region One-To-May Mapping By Fluent API
            //One-To-Many Relationship
            modelBuilder.Entity<Employee>()
                .HasOne(emp => emp.Department) //Navigation Property
                .WithMany(dept => dept.Employees) //Navigation Property
                //.HasForeignKey(emp => emp.DepartmentID) //Foreign Key
                //.IsRequired(true) //doesn't Allow Null
                .OnDelete(DeleteBehavior.Cascade); //Cascade Delete 
            #endregion

            #region Many-To-Many Mapping By Fluent API

            modelBuilder.Entity<StudentSubject>()
                .HasKey(StudentSubject => new { StudentSubject.StudentID, StudentSubject.SubjectID }); //Composite Key

            modelBuilder.Entity<Student>()
                .HasMany(St => St.StudentSubjects)
                .WithOne(StSu => StSu.Student);

            modelBuilder.Entity<Subject>()
                .HasMany(sub => sub.StudentSubjects)
                .WithOne(StSu => StSu.Subject);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        //DbSets
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; } //Many-To-Many with Extra Attributes

    }
}
