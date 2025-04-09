using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class StudentSubject
    {
        //FKs
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        
        //Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

        //Extra Attributes
        public int Grade { get; set; } //Marks in Subject
    }
}
