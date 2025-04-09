
using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using System.Data.SqlClient;
using Day04Dapper;



namespace D04Dapper
{
    class Program
    {
        public static void Main(string[] args)
        {
            var connection = new SqlConnection("Data Source=.;Initial Catalog=ITI;Integrated Security=True");

            #region Queries
            ////var result = connection.Query<Student>("SELECT * FROM Student");
            //var result = connection.Query<Student>("SELECT * FROM Student WHERE St_Id = @Id", new { Id = 1 });

            //foreach (var student in result)
            //{
            //    Console.WriteLine(
            //        $"ID: {student.St_Id}, " +
            //        $"Name: {student.St_Fname} " +
            //        $"{student.St_Lname}, " +
            //        $"Address: {student.St_Address}, " +
            //        $"Age: {student.St_Age}"
            //        );
            //}
            #endregion

            #region Stored Procedure
            //var studentsFromCairo = connection.Query<Student>("ShowStudentsFromCairo", commandType: System.Data.CommandType.StoredProcedure);

            //foreach (var student in studentsFromCairo)
            //{
            //    Console.WriteLine(
            //        $"ID: {student.St_Id}, " +
            //        $"Name: {student.St_Fname} " +
            //        $"{student.St_Lname}, " +
            //        $"Address: {student.St_Address}, " +
            //        $"Age: {student.St_Age}"
            //        );
            //}
            #endregion
        }
    }
}