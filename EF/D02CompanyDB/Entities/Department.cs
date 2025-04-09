using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class Department
    {
        public int deptID { get; set; } 
        public string Name { get; set; }
        public int YearOfCreation { get; set; }

        //Navigation Property
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //1 to Many
    }
}
