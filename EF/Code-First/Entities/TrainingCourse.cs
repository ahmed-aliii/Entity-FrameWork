using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    /*
     => Mapping Object Model (4 Ways)
        1) Follow EF core Convention (in Entity Class)
        2) Data Annotations (in Entity Class)
        3) Fluent API (OnModelCeating Function in DbContext Class)
        4) Configuration class (Separate class per Entity)
     */

    [Table("Courses")] //Table Name
    public class TrainingCourse
    {
        //Properties Annotations => Constraints
        [Key] //CourseNumber PK
        public int CourseNumber { get; set; } //PK

        [Required] //Not Null
        [MaxLength(50)] //nvarchar(50)
        public string CourseTitle { get; set; }

        [Column("Duration" , TypeName = "int")]
        public short CourseDuration { get; set; }

        [Required]      //Not Null
        [MinLength(10)] //nvarchar(10)
        [MaxLength(300)] //nvarchar(300)
        public string CousreURL { get; set; } //nvarchar(max)

        //Navigational Property (FK->PK) => Follow EF Convention
        //Many-To-Many Relationship with Employee
        public virtual ICollection<Employee> Employees { get; set; }
        public TrainingCourse()
        {
            Employees = new HashSet<Employee>();
        }
    }
}
