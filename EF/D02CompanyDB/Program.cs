using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;

namespace D02CompanyDB
{
    class Program
    {
        public static void Main()
        {

            using (CompanyDBContext context = new CompanyDBContext())
            {
                context.Database.Migrate(); // Code Equivalent to Update-Database

                #region Validation
                //Employee E01 = new Employee() //values Not Valid
                //{
                //    Name = "John",
                //    EmpSalary = 1000,
                //    Age = 10,
                //    //Email = "Johnnnn@gmail.com",
                //};

                //Console.WriteLine(context.Entry(E01).State);
                //Console.WriteLine(context.Employees.Local.Count);

                //context.Employees.Add(E01); // Add to Context

                //Console.WriteLine(context.Entry(E01).State);
                //Console.WriteLine(context.Employees.Local.Count);

                //context.SaveChanges(); // Save to Database

                //Console.WriteLine(context.Entry(E01).State);
                //Console.WriteLine(context.Employees.Local.Count);

                //Console.WriteLine(E01.ID); 
                #endregion


                #region Many-To-Many

                //Student S01 = new Student() { Name = "Ahmed" };
                //Student S02 = new Student() { Name = "Ali" };

                //Subject Sub01 = new Subject() { Title = "Math" };
                //Subject Sub02 = new Subject() { Title = "Physics" };
                //Subject Sub03 = new Subject() { Title = "Chemistry" };

                //StudentSubject SS01 = new StudentSubject() { Student = S01, Subject = Sub01, Grade = 80};
                //StudentSubject SS02 = new StudentSubject() { Student = S01, Subject = Sub02, Grade = 90 };
                //StudentSubject SS03 = new StudentSubject() { Student = S02, Subject = Sub02, Grade = 90 };
                //StudentSubject SS04 = new StudentSubject() { Student = S02, Subject = Sub03, Grade = 100 };


                //S01.StudentSubjects.Add(SS01);
                //S01.StudentSubjects.Add(SS02);

                //S02.StudentSubjects.Add(SS03);
                //S02.StudentSubjects.Add(SS04);

                ////Add to SbSets
                //context.Students.AddRange(new Student[] { S01, S02 });
                //context.Subjects.AddRange(new Subject[] { Sub01, Sub02, Sub03 });
                ////context.StudentSubjects.AddRange(new StudentSubject[] { SS01, SS02, SS03, SS04 });


                //context.SaveChanges(); // Save to Database

                #endregion


            }


        }
    }
}