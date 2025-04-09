using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04Dapper
{
    public partial class Student
    {
        public int St_Id { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_Address { get; set; }
        public int? St_Age { get; set; }
        public int? Dept_Id { get; set; }
        public int? St_super { get; set; }
    }
}
