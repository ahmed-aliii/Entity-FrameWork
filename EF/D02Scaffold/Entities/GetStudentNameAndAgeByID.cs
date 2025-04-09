using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02Scaffold
{
    [Keyless]
    public class GetStudentNameAndAgeByID
    {
        [Column("SName")]
        public string? SName { get; set; }
        [Column("SAge")]
        public int? SAge { get; set; }
    }
}
