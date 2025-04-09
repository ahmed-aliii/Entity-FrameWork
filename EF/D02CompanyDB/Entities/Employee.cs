using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    /*
     4 ways to Map Object Model
        1. EF convention (Default Action)
        2. Data Annotations
        3. Fluent API (in Context class) OnModelCreating -> modelBuilder
        4. Configuration class (separate class oer entity)
     */
    public class Employee
    {
        public int ID { get; set; } // Numeric ,public property , ID - EmployeeID, => PK
        [MaxLength(50)] //nvarchar(50)
        public string Name { get; set; } //Ref Type : allow Null
        [Column( "Salary" , TypeName = "money")] //decimal(18,2)
        public double EmpSalary { get; set; } //Value : Not Null
        [Range(20 , 99)] //Range 20 to 99
        public int? Age { get; set; } //Nullable : allow Null
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        
        //Navigation Property/Lazy Loading
        public virtual Department Department { get; set; } //FK
        
        //Foreign Key
        public int? DepartmentID { get; set; } //FK
    }
}
