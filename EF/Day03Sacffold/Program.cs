
using Day03Scaffold.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Transactions;

namespace D03Scaffold
{
    class Program
    {
        
        public static async Task Main()
        {
            using (ITIContext context = new ITIContext())
            {
                //Object of procedures context
                var procContext = new ITIContextProcedures(context);
                #region Scaffold SP Async Functions Use

                //var stFromCairo = await procContext.ShowStudentsFromCairoAsync();
                //foreach (var item in stFromCairo)
                //{
                //    Console.WriteLine(item.St_Id + " " + item.St_Fname + " " + item.St_Lname);
                //}

                //Console.WriteLine();
                //Console.WriteLine();

                //var fady = await procContext.StudentByIDAsync(7);
                //foreach (var item in fady)
                //{
                //    Console.WriteLine(item.St_Id + " " + item.St_Fname + " " + item.St_Lname);
                //}
                //Console.WriteLine();
                //Console.WriteLine();

                #endregion


                #region Scaffold View Use
                //var stNameView = context.StudNames.ToList();
                //foreach (var item in stNameView)
                //{
                //    Console.WriteLine(item.St_Id + " " + item.St_Fname);
                //}
                #endregion


                #region Lazy Loading Vs Eager Loaging 
                ////Deptartment (one) - To - (Many) Student
                ////1)Lazy Loading => Default
                ////=> it will get department data only 
                ////=> Navigational Properties => Null

                //Console.WriteLine();
                //Console.WriteLine("---------------Lazy Loading ------------");
                //Console.WriteLine();

                //var result = context .Departments.ToList();
                //foreach(var item in result)
                //{
                //    Console.Write($"Department : {item.Dept_Id} , {item.Dept_Name}   -> Has Students : ");
                //    foreach (var st in item.Students)
                //    {
                //        Console.Write($"({st.St_Id} , {st.St_Fname}) ");

                //    }
                //    Console.WriteLine();
                //}

                //Console.WriteLine();
                //Console.WriteLine("---------------Eager Loading ------------");
                //Console.WriteLine();

                ////2)Eager Loading => Include
                ////=> it will get department data and all students (Navigational Property) data
                //var resultWithInclude = context.Departments.Include(dept => dept.Students).ToList();
                //foreach (var item in resultWithInclude)
                //{
                //    Console.Write($"Department : {item.Dept_Id} , {item.Dept_Name}   -> Has Students : ");
                //    foreach (var st in item.Students)
                //    {
                //        Console.Write($"({st.St_Id} , {st.St_Fname}) ");
                //    }
                //    Console.WriteLine();
                //}

                #endregion


                #region Local 

                ////Get Data From DataBase
                ////Now All Data is in Memory/Local
                //var result = context.Students.ToList();


                //foreach (var st in result)
                //{
                //    Console.WriteLine($"({st.St_Id} , {st.St_Fname}) ");
                //}

                //Console.WriteLine();
                //Console.WriteLine();

                ////Get Data From Local
                //var resultFromLocal = context.Students.Local.ToList();
                //Console.WriteLine($"Local Count : {context.Students.Local.Count}");
                //foreach (var st in resultFromLocal)
                //{
                //    Console.WriteLine($"({st.St_Id} , {st.St_Fname}) ");
                //}

                //Console.WriteLine();
                //Console.WriteLine();

                //var cairoStudsFromLocal = context.Students.Local.Where(st => st.St_Address == "Cairo").ToList();
                //foreach (var st in cairoStudsFromLocal)
                //{
                //    Console.WriteLine($"({st.St_Id} , {st.St_Fname} , {st.St_Address}) ");
                //}

                #endregion


                #region Find() Method

                //Find() Method
                //Searching for a single entity by its primary key
                //Seaching in Local First if not Found then in DataBase
                //returns null if not found in Local Or DataBase

                //var st = context.Students.Find(1);

                //if (st != null)
                //    Console.WriteLine($"({st.St_Id} , {st.St_Fname}) ");
                //else
                //    Console.WriteLine("Not Found in Local Or DataBase");

                #endregion


                #region ExecuteSqlRaw() => For Sql DML 

                //context.Database.ExecuteSqlRaw("UPDATE Student SET St_Fname = 'William' WHERE St_Id = 1");

                //var st = context.Students.Find(1);

                //if (st != null)
                //    Console.WriteLine($"({st.St_Id} , {st.St_Fname}) ");
                //else
                //    Console.WriteLine("Not Found in Local Or DataBase");
                //Console.WriteLine(context.Students.Local.Count);

                #endregion


                #region AsNoTracking()

                ////AsNoTracking() => For Read Only
                ////make data not tracked by context
                ////State Tracker Will Not be Updated

                //var unTrackedStudent = context.Students.AsNoTracking().FirstOrDefault();

                //Console.WriteLine( context.Entry(unTrackedStudent).State );

                //unTrackedStudent.St_Fname = "Name";

                //Console.WriteLine(context.Entry(unTrackedStudent).State);


                #endregion

            }
        }
    }
}