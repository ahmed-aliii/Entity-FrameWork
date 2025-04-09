using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02Scaffold.Entities
{
    [Keyless]
    public class StudentDTO
    {
        public string? St_Fname { get; set; }
        public string? St_Address { get; set; }
        public int? St_Age { get; set; }
    }
}
