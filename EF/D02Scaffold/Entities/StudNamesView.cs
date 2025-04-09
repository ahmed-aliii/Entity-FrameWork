using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02Scaffold
{
    [Keyless]
    public class StudNamesView
    {
        public int? St_Id { get; set; }
        public string? St_Fname { get; set; }
    }
}
