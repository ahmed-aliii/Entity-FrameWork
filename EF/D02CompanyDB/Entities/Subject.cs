using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class Subject
    {
        public int ID { get; set; }

        [Required] //Not Null
        [MaxLength(100)]
        public string Title { get; set; }

        //Many-To-Many with NO Relationship Extra Attributes
        //public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>(); //Navigation Property

        //Many-To-Many with Relationship Extra Attributes
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>(); //Navigation Property

    }
}
