using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    /*
     => POCO (Plain Old CLR Object) Class
       // Not contain any EF code
     */
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        //Navigational Property (FK->PK)
        public virtual ICollection<Employee> Employees { get; set; }
        public Department()
        {
            Employees = new HashSet<Employee>(); //No Duplicates
            
        }

    }
}
