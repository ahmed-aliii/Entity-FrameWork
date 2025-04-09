using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;

namespace Code_First
{
    class Program
    {
        public static void Main()
        {

            #region using keyword
            //using keyword Generate following code
            //EnterpriseContext context = new EnterpriseContext();
            //try
            //{
            //.
            //code ...
            //.
            //}
            //finally
            //{
            //   context.Dispose(); //To Clean Up => Release unmanaged resources
            //} 
            #endregion

            //DataBase Object   
            using (EnterpriseContext context = new EnterpriseContext())
            {
                #region Very Bad practice drop, create
                ////Very bad practice to Drop , Create DB each Run to code
                //context.Database.EnsureDeleted();

                ////1)check or Create DataBase if not exist
                //context.Database.EnsureCreated(); 
                #endregion

                #region Migration => Good practice

                // => Migration to Create DataBase and migrate every time DB structure changes
                // Two ways to create Migration
                // 1) CLI Migration
                // 2) context.Database.Migrate() Migration

                context.Database.Migrate();


                #endregion

                #region Insert

                ////2) Department Objects (Rows - Records)
                //Department D01 = new Department()
                //{
                //    //DepartmentID = 1,//Auto Incremented (Convension Named PK)
                //    Name = "IT",
                //};
                //Department D02 = new Department()
                //{
                //    //DepartmentID = 2,//Auto Incremented (Convension Named PK)
                //    Name = "Engineering",
                //};
                ////=>3) Add Department Objects to DbSet<T> Property
                //context.Departments.Add(D01);
                //context.Departments.Add(D02);

                ////=>4) Save Changes to DataBase => Commit All Changes
                //context.SaveChanges();

                //Console.WriteLine(D01.DepartmentID);
                //Console.WriteLine(D02.DepartmentID); 
                #endregion

                #region Update - Select

                ////L2EF => Select
                //var results = context.Departments.Where(dept => dept.Name == "HR");

                //Department D01 = results.FirstOrDefault();

                ////Update One Table Only 
                ///*
                // if(D01 != null)
                //{
                //    D01.Name = "Information Technology";
                //    context.Departments.Update(D01); //Not Required
                //}
                // */

                ////Show Local Department Data
                //Console.WriteLine(context.Departments.Local.Count);

                ////Update
                //if (D01 != null)
                //    D01.Name = "IT";
                //else
                //    Console.WriteLine("Department Not Found");

                ////Show Object/Row State 
                //if (D01 != null)
                //    Console.WriteLine(context.Entry(D01).State);
                //else
                //    Console.WriteLine("Not Found");

                ////Save/Commit all changes To DataBase
                //context.SaveChanges();

                #endregion

                #region Delete

                ////remove from local
                //context.Departments.Remove(context.Departments.First());


                ////remove from database
                //context.SaveChanges();
                #endregion

                #region Test Migration 
                //TrainingCourse course = new TrainingCourse()
                //{
                //    //CourseNumber = 1, //Auto Incremented PK
                //    CourseTitle = "C#",
                //    CourseDuration = 30,
                //    CousreURL = "https://www.anything.com",
                //};


                ////Add Course Object to DbSet<T> Property
                //context.Courses.Add(course);
                context.Departments.Add(new Department()
                {
                    Name = "hr"
                });
                context.Employees.Add(new Employee()
                {
                    //EmployeeID = 1, //Auto Incremented PK
                    FName = "John",
                    LName = "Doe",
                    Age = 50,
                    Salary = 50000,
                    DepartmentID = 1,
                    Address = "123 Main St",
                });


                context.SaveChanges(); 
                #endregion
            }



        }
    }
}