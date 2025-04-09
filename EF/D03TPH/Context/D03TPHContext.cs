using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace D03TPH.Context
{
    class D03TPHContext : DbContext
    {
        //DbSets
        #region TPH Mapping => 1) DBSet for every Concrete Type
        ////TPH Mapping => DBSet for every Concrete Type
        //public virtual DbSet<Teacher> Teachers { get; set; }
        //public virtual DbSet<Student> Students { get; set; } 
        #endregion

        #region TPH Mapping => 2) Single DBSet for Heirarchy
        public virtual DbSet<Person> People { get; set; }
        #endregion


        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH Mapping => 1) DBSet for every Concrete Type
            //modelBuilder.Entity<Teacher>()
            //    .HasBaseType<Person>();

            //modelBuilder.Entity<Student>()
            //    .HasBaseType<Person>();
            #endregion

            #region TPH Mapping => 2) Single DBSet for Heirarchy
            modelBuilder.Entity<Teacher>()
                .HasBaseType<Person>();

            modelBuilder.Entity<Student>()
                .HasBaseType<Person>();
            #endregion

            #region User-Defined Discrimnator 
            //modelBuilder.Entity<Person>()
            //    .HasDiscriminator<bool>(p => p.IsEmployee)
            //    .HasValue<Teacher>(true)
            //    .HasValue<Student>(false);
            #endregion

            base.OnModelCreating(modelBuilder);
        }






        //Database connection 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TablePerHeirarchyDB ;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
