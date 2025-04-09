using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03TPH
{
    //Hierarchical Data Model
    public abstract  class Person
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        //Discrimnator Property 
        //public bool IsEmployee { get; protected set; }
    }

    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
    }

    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
