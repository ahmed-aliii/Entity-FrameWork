using D03TPH.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;

namespace D03TPH
{
    class Program
    {
        public static void Main()
        {
            using (D03TPHContext context =  new D03TPHContext())
            {
                #region 1) TPH Mapping => DBSet for every Concrete Type

                //Teacher T01 = new Teacher
                //{
                //    FullName = "Ahmed Ali",
                //    HireDate = DateTime.Now
                //};
                //Student S01 = new Student
                //{
                //    FullName = "Jane Smith",
                //    EnrollmentDate = DateTime.Now
                //};

                ////add to context
                //context.Teachers.Add(T01);
                //context.Students.Add(S01);

                ////save changes
                //context.SaveChanges();

                ////get all Teachers
                //var teachers = context.Teachers.ToList();
                //foreach (var teacher in teachers)
                //{
                //    Console.WriteLine($"Teacher ID: {teacher.ID}, Name: {teacher.FullName}, Hire Date: {teacher.HireDate}");
                //}
                //Console.WriteLine();
                ////get all Students
                //var students = context.Students.ToList();
                //foreach (var student in students)
                //{
                //    Console.WriteLine($"Student ID: {student.ID}, Name: {student.FullName}, Enrollment Date: {student.EnrollmentDate}");
                //}
                #endregion

                #region TPH Mapping => 2) Single DBSet for Heirarchy

                //Teacher T01 = new Teacher
                //{
                //    FullName = "Ahmed Ali",
                //    HireDate = DateTime.Now
                //};
                //Student S01 = new Student
                //{
                //    FullName = "Jane Smith",
                //    EnrollmentDate = DateTime.Now
                //};

                ////add to context
                //context.People.Add(T01);
                //context.People.Add(S01);

                ////save changes
                //context.SaveChanges();

                ////get all Teachers
                //var teachers = context.People.OfType<Teacher>().ToList();
                //foreach (var teacher in teachers)
                //{
                //    Console.WriteLine($"Teacher ID: {teacher.ID}, Name: {teacher.FullName}, Hire Date: {teacher.HireDate}");
                //}
                //Console.WriteLine();
                ////get all Students
                //var students = context.People.OfType<Student>().ToList();
                //foreach (var student in students)
                //{
                //    Console.WriteLine($"Student ID: {student.ID}, Name: {student.FullName}, Enrollment Date: {student.EnrollmentDate}");
                //}

                #endregion


            }
        }
    }
}