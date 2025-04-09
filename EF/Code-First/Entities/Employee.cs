using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    /*
     => POCO (Plain Old CLR Object) Class
       // Not contain any EF code
     */
    public class Employee
    {
        public int ID { get; set; } //PK
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal Salary { get; set; }
        public int? Age { get; set; } //Nullable Property=> Allow Null Values
        [MaxLength(30)]
        public string Address { get; set; } 

        //Navigational Property (FK->PK)
        public virtual int DepartmentID { get; set; }

        public virtual ICollection<TrainingCourse> Courses { get; set; } //Many-To-Many Relationship with TrainingCourse
        public Employee()
        {
            Courses = new HashSet<TrainingCourse>();
        }

    }
}
