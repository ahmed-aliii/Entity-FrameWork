
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02CompanyDB
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> EntityBuilder)
        {
            EntityBuilder.HasKey(dept => dept.deptID);

            EntityBuilder.Property(dept => dept.Name)
                        .IsRequired() //Not Null
                        .HasMaxLength(50); //nvarchar(50)

            EntityBuilder.Property(dept => dept.YearOfCreation)
                         .HasDefaultValue(DateTime.Now.Year)
                         .IsRequired(); //Not Null
        }
    }
}
