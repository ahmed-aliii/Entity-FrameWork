using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Many-To-Many with no Relationship Extra Attributes
        //public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>(); //Navigation Property

        //Many-To-Many with Relationship Extra Attributes
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>(); //Navigation Property
    }
}
