using D02Scaffold.Context;
using D02Scaffold.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Transactions;

namespace D02Scaffold
{
    class Program
    {
        public static void Main()
        {

            using (ITIContext context = new ITIContext())
            {
                #region Run SQL in EF
                //// Get all students using SP
                //var Allstuds = context.Students.FromSqlRaw("select * from Student").ToList();

                //foreach (var stud in Allstuds)
                //{
                //    Console.WriteLine
                //         (
                //             $"Student ID: {stud.St_Id}, " +
                //             $"Name: {stud.St_Fname} , " +
                //             $"Address: {stud.St_Address} , " +
                //             $"Dept_Id: {stud.Dept_Id} , " +
                //             $"Age: {stud.St_Age}"
                //         );
                //}

                //Console.WriteLine();


                //// Get all students using SP
                //var studs = context.Students.FromSqlRaw("EXEC ShowStudentsFromCairo").ToList();

                //foreach (var stud in studs)
                //{
                //    Console.WriteLine($"Student ID: {stud.St_Id}, Name: {stud.St_Fname} , Address: {stud.St_Address}");
                //}
                //Console.WriteLine();

                ////Get Student By Id using SP
                ////var studById = context.Students.FromSqlRaw("EXEC StudentByID @p0", 1).ToList();
                //var studById = context.Students.FromSqlInterpolated($"EXEC StudentByID {1}").ToList();
                //foreach (var stud in studById)
                //{
                //    Console.WriteLine
                //        (
                //        $"Student ID: {stud.St_Id}, " +
                //        $"Name: {stud.St_Fname} , " +
                //        $"Address: {stud.St_Address} , " +
                //        $"Dept_Id: {stud.Dept_Id} , " +
                //        $"Age: {stud.St_Age}"
                //        );
                //}


                //Console.WriteLine();
                //Console.WriteLine();

                #endregion

                #region Input Output parameter SP
                ////input parameters
                //SqlParameter sid = new SqlParameter()
                //{
                //    ParameterName = "@sid",
                //    SqlDbType = SqlDbType.Int,
                //    Value = 7
                //};
                ////output parameters
                //SqlParameter SName = new SqlParameter()
                //{
                //    ParameterName = "@SName",
                //    SqlDbType = SqlDbType.VarChar,
                //    Size = 20,
                //    Direction = ParameterDirection.Output
                //};
                //SqlParameter SAge = new SqlParameter()
                //{
                //    ParameterName = "@SAge",
                //    SqlDbType = SqlDbType.VarChar,
                //    Size = 20,
                //    Direction = ParameterDirection.Output
                //};

                //var val =
                //    context.Set<GetStudentNameAndAgeByID>()
                //    .FromSqlRaw("EXEC GetStudentNameAndAgeByID @sid ,@SName , @SAge", sid, SName, SAge).ToList();

                //foreach (var item in val)
                //{
                //    Console.WriteLine($"Name: {item.SName.ToString()} , Age: {item.SAge.ToString()}");
                //} 
                #endregion

                #region Keyless Entity (Use Case 1 => select statment)
                ////Keyless Entity
                ////used to map the result of a select statment or a stored procedure or a view to a class
                //var studs = context.Set<StudentDTO>().FromSqlRaw("Select St_Fname, St_Address, St_Age from Student").ToList();
                //foreach (var stud in studs)
                //{
                //    Console.WriteLine($"Name: {stud.St_Fname} , Address: {stud.St_Address} , Age: {stud.St_Age}");
                //}
                #endregion

                #region Keyless Entity (Use Case 2 => view)
                ////Keyless Entity
                ////used to map the result of a select statment or a stored procedure or a view to a class
                //var studs = context.StudNames.ToList();
                //foreach (var stud in studs)
                //{
                //    Console.WriteLine($" ST_ID: {stud.St_Id} , Name: {stud.St_Fname}");
                //}
                #endregion


            }


        }
    }
}